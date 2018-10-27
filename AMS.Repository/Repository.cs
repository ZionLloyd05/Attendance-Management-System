using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMS.DAL;
using AMS.DAL.Entities;

namespace AMS.Repository
{
    public class Repository : IRepository
    {

        AMSEntities ctx;

        public Repository()
        {
            ctx = new AMSEntities();
        }

        public int Create(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetAll(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEntity GetOne(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        #region Helper Methods
        private static string GetType(IEntity entity)
        {
            return entity.GetType().Name;
        }

        private int add(IEntity entity)
        {
            if (GetType(entity) == "Student")
            {
                ctx.Students.Add((Student)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "Lecturer")
            {
                ctx.Lecturers.Add((Lecturer)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "Course")
            {
                ctx.Courses.Add((Course)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "Attendance")
            {
                ctx.Attendances.Add((Attendance)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "StdAttendance")
            {
                ctx.StdAttendances.Add((StdAttendance)entity);
                return ctx.SaveChanges();
            }
            else
            {
                return 0;
            }
            
        }

        private int remove(IEntity entity)
        {
            if (GetType(entity) == "Student")
            {
                ctx.Students.Remove((Student)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "Lecturer")
            {
                ctx.Lecturers.Remove((Lecturer)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "Course")
            {
                ctx.Courses.Remove((Course)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "Attendance")
            {
                ctx.Attendances.Remove((Attendance)entity);
                return ctx.SaveChanges();
            }
            else if (GetType(entity) == "StdAttendance")
            {
                ctx.StdAttendances.Remove((StdAttendance)entity);
                return ctx.SaveChanges();
            }
            else
            {
                return 0;
            }

        }

        private IEntity getOne(IEntity entity)
        {
            if (GetType(entity) == "Student")
            {
                var student = (Student)entity;
                return ctx.Students.Find(student.matricNo);
            }
            else if (GetType(entity) == "Course")
            {
                var course = (Course)entity;
                return ctx.Courses.Find(course.courseCode);
            }
            else if (GetType(entity) == "Lecturer")
            {
                var lecturer = (Lecturer)entity;
                return ctx.Lecturers.Find(lecturer.lecturerId);
            }
            else if (GetType(entity) == "Attendance")
            {
                var attendance = (Attendance)entity;
                return ctx.Attendances.Find(attendance.attendanceId);
            }
            else if (GetType(entity) == "StdAttendance")
            {
                var stdAttendance = (StdAttendance)entity;
                return ctx.StdAttendances.Find(stdAttendance.std_attId);
            }

            return null;
        }

        private IEnumerable<IEntity> _GetAll(IEntity entity)
        {
            if (GetType(entity) == "Student")
            {
                return ctx.Students;
            }
            else if (GetType(entity) == "Course")
            {
                return ctx.Courses;
            }
            else if (GetType(entity) == "Lecturer")
            {
                return ctx.Lecturers;
            }
            else if (GetType(entity) == "Attendance")
            {
                return ctx.Attendances;
            }
            else if (GetType(entity) == "StdAttendance")
            {
                return ctx.StdAttendances;
            }

            return null;
        }
        #endregion
    }
}
