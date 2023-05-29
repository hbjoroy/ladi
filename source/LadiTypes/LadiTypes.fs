namespace LadiTypes
open System

// Contract for the LadiTypes module
type WorkOrder = {
    WorkOrderID: Guid // Unique ID for the work order instance
    WorkOrderType: string // Type of work order
    WorkOrderPayload: string option // Payload of the work order
}

// Types below are internal to the execution
type WorkOrderExecution = {
    WorkOrder: WorkOrder
    WorkOrderStatus: string option // Status of the work order
}

type WorkTask = {
    WorkOrderID: Guid // Unique ID for the work order instance
    WorkTaskID: Guid // Unique ID for the work task instance
    WorkTaskType: string // Type of work task
    WorkTaskStatus: string option // Status of the work task
    WorkTaskPayload: string option // Payload of the work task
}