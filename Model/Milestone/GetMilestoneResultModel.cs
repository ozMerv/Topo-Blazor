﻿namespace Topo.Model.Milestone
{
    public class GetMilestoneResultModel
    {
        public MilestoneResult[] results { get; set; } = new MilestoneResult[0];
    }

    public class MilestoneResult
    {
        public string id { get; set; } = string.Empty;
        public string member_id { get; set; } = string.Empty;
        public string section { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public DateTime status_updated { get; set; }
        public string milestone_requirement_status { get; set; } = string.Empty;
        public Event_Log[] event_log { get; set; } = new Event_Log[0];
        public Event_Count event_count { get; set; } = new Event_Count();
        public Achievement_Meta achievement_meta { get; set; } = new Achievement_Meta();
        public string template { get; set; } = string.Empty;
        public int version { get; set; }
        public Imported imported { get; set; } = new Imported();
        public DateTime last_updated { get; set; }
    }

    public class Event_Count
    {
        public Participant participant { get; set; } = new Participant();
        public Assistant assistant { get; set; } = new Assistant();
        public Leader leader { get; set; } = new Leader();
    }

    public class Participant
    {
        public float community { get; set; }
        public float outdoors { get; set; }
        public float creative { get; set; }
        public float personal_growth { get; set; }
    }

    public class Assistant
    {
        public float community { get; set; }
        public float outdoors { get; set; }
        public float creative { get; set; }
        public float personal_growth { get; set; }
    }

    public class Leader
    {
        public float community { get; set; }
        public float outdoors { get; set; }
        public float creative { get; set; }
        public float personal_growth { get; set; }
    }

    public class Achievement_Meta
    {
        public int stage { get; set; }
    }

    public class Imported
    {
        public Awarded_By awarded_by { get; set; } = new Awarded_By();
        public Event_Count event_count { get; set; } = new Event_Count();
        public string date_awarded { get; set; } = string.Empty;
    }

    public class Awarded_By
    {
        public string id { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
    }

    public class Event_Log
    {
        public string credit_type { get; set; } = string.Empty;
        public string challenge_area { get; set; } = string.Empty;
        public string event_id { get; set; } = string.Empty;
        public string event_name { get; set; } = string.Empty;
        public DateTime event_start_datetime { get; set; }
    }

}
