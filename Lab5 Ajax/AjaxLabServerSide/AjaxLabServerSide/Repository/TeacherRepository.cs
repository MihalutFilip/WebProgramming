using AjaxLabServerSide.Context;
using AjaxLabServerSide.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Repository
{
    public class TeacherRepository
    {
        public List<int> GetTeachersIDs()
        {
            var result = new List<int>();
            using (var context = new AjaxContext())
            {
                result = context.Teachers.Select(x => x.Id).ToList();
            }

            return result;
        }

        public Teacher GetTeacher(int id)
        {
            using (var context = new AjaxContext())
            {
                return context.Teachers.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Update(Teacher teacher)
        {
            using (var context = new AjaxContext())
            {
                var DBteacher = context.Teachers.FirstOrDefault(x => x.Id == teacher.Id);
                DBteacher.Name = teacher.Name;
                context.SaveChanges();
            }
        }
    }
}