// File:    Term.cs
// Created: Wednesday, April 15, 2020 12:00:29 PM
// Purpose: Definition of Class Term

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Term : IIdentifiable<long>
   {
      public long TermId { get; set; }
      private DateTime startTime;
      private DateTime endTime;
      private DateTime date;
        
      public Doctor Doctor { get; set; }
      private User user;
        private long v;

        

		public long GetId()
		{
			return TermId;
		}

		public void SetId(long id)
		{
            TermId = id;
		}
	}
}