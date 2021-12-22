using System;
using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class TaskInfoResponseData:ResponseDataBase
    {
        public TaskInfoResponseData()
        {
            Tasks = new List<TaskStatus>();
        }

        public IList<TaskStatus> Tasks { get; set; }
    }

    public class TaskStatus
    {
        public Guid Id { get; set; }
        public int State { get; set; }
        public long ElapsedSeconds { get; set; }
        public long RemainingSeconds { get; set; }
        public string Result { get; set; }
        public string ErrorMessage { get;set; }
    }

    public class TaskState
    {
        public const int Created = 0;
        public const int Running = 1;
        public const int RanToCompletion = 2;
        public const int Paused = 3;
        public const int Canceled = 4;
        public const int Faulted = 5;
    }
}
