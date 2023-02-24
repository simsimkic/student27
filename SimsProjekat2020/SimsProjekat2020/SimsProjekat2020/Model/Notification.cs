// File:    Notification.cs
// Created: Thursday, April 16, 2020 8:28:54 PM
// Purpose: Definition of Class Notification

using System;

namespace Model
{
   public class Notification
   {
      private DateTime date;
      private string message;


        public Notification(string message) 
        {
            message = message;
        }
      
    }
}