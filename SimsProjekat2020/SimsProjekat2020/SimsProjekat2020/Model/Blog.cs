// File:    Blog.cs
// Created: Wednesday, April 15, 2020 7:29:58 PM
// Purpose: Definition of Class Blog

using SimsProjekat2020.Repository.Interfaces;
using System;

namespace Model
{
   public class Blog : IIdentifiable<string>
   {
      public string Title { get; set; }
      public string Text { get; set; }
      public string Category { get; set; }
      public DateTime RealiseDate { get; set; }
      public Doctor Author { get; set; }

        public Blog() { }
        public Blog(string title, string text, string category, DateTime date, Doctor doc) {
            Title = title;
            Text = text;
            Category = category;
            RealiseDate = date;
            Author = doc;
        }

        public string GetId()
        {
            return Title;
        }

        public void SetId(string title)
        {
            Title = Title;
        }
    }
}