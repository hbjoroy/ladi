# Λάδι - Ladi

This is an experiment project that starts out for trying to implement a simple task executor, that use some kind of bus to pick up next task, and run the next step along the way.

The name - well, has to be called something. Ladi means "oil", so maybe it's supposed to oil the machinery?

## First goal

Continiously check for new jobs, then prepare them for execution by workers, according to work order type.

Support that workers messages back that the work is done

Also create workers that accepts a job, executes it and reports back.

The workers accetpts data as input (json) and emits data that is returned to Ladi.
