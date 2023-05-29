open System
open LadiTypes
open System.Text.Json

let getOrder () =
    {
        WorkOrderID = Guid.NewGuid()
        WorkOrderType = "Test"
        WorkOrderPayload = Some (JsonSerializer.Serialize ({| Started = DateTime.Now |}))
    }

let executeOrder order orderStorage taskStarter = 
    {
        WorkOrder = order
        WorkOrderStatus = Some "Started"
    }
    |> orderStorage
    |> taskStarter

executeOrder 
    (getOrder ()) 
    (fun order -> 
        printfn "Order: %A" order
        order)         
    (fun order -> 
        {
            WorkOrderID = order.WorkOrder.WorkOrderID
            WorkTaskID = Guid.NewGuid()
            WorkTaskType = "Test"
            WorkTaskStatus = Some "Started"
            WorkTaskPayload = order.WorkOrder.WorkOrderPayload
        }
        |> fun  task -> 
            printfn "Task: %A" task
            task
        )
|> ignore