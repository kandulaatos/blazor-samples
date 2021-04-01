﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_timelinedata
{
    public class TimelineData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime? BaselineStartDate { get; set; }
            public DateTime? BaselineEndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public int?ParentId { get; set; }
            public object ResourceId { get; set; }
            public string Notes { get; set; }
            public string TaskType { get; set; }
        }
       
        public static List<TaskData> TimelineRecord()
        {
            List<TaskData> Tasks = new List<TaskData>() {

        new TaskData() {
           TaskId = 1,
            TaskName = "Project initiation",
            StartDate = new DateTime(2019, 04, 03),
            EndDate = new DateTime(2019, 04, 21),
        },
        new TaskData() {
                    TaskId = 2,
                    TaskName = "Identify site location",
                    StartDate = new DateTime(2019, 04, 03),
                    Duration = "5",
                    Progress = 70,
                    ParentId=1
        },
            new TaskData() {
                    TaskId = 3,
                    TaskName = "Perform soil test",
                    StartDate = new DateTime(2019, 04, 03),
                    Duration = "5",
                    Progress = 50,
            ParentId = 1
        },
         new TaskData() {
                    TaskId = 4,
                    TaskName = "Soil test approval",
                    StartDate = new DateTime(2019, 04, 03),
                    Duration = "5",
                    Progress = 50,
               
            ParentId = 1,
            Predecessor="2"

        },
         new TaskData(){
         TaskId = 5,

            TaskName = "Project estimation",
            StartDate = new DateTime(2019, 04, 10),
            EndDate = new DateTime(2019, 04, 21),



        },
         new TaskData() {
                    TaskId = 6,
                    TaskName = "Develop floor plan for estimation",
                    StartDate = new DateTime(2019, 04, 10),
                    Duration = "5",
            ParentId=5

        },
        new TaskData() {
                    TaskId = 7,
                    TaskName = "List materials",
                    StartDate = new DateTime(2019, 04, 10),
                    Duration = "5",
                    Progress = 50,
            ParentId = 5
        },
           
        
    };

            return Tasks;
        }
    }
}
