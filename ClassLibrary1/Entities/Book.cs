using BookStore.DAL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Entities
{
    public class Book: IBaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; } 
        public string Publisher { get; set; }   
        public string Author { get; set; }  

    }
}
