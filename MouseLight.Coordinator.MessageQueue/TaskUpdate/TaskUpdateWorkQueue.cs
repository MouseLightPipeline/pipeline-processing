﻿using System;

using MouseLight.Core.Threading;

namespace MouseLight.Coordinator.MessageQueue.TaskUpdate
{
    public class TaskUpdateWorkQueue : BackgroundTaskQueue<TaskUpdateWorkItem>
    {
        public TaskUpdateWorkQueue()
        {
        }
    }
}
