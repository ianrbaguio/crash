﻿namespace Crash.Models.Entities
{
    public class Party
    {
        public int PartyId { get; set; }
        public Guid AccidentId { get; set; }
        public string License { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string Address { get; set; }
      //  public Accident Accident { get; set; }
    }
}