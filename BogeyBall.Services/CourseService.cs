using BogeyBall.Data;
using BogeyBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Services
{
    public class CourseService
    {
        private readonly Guid _userId;

        public CourseService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCourse(CourseCreate model)
        {
            var entity =
                new Course()
                {
                    Id = model.CourseId,
                    Name = model.CourseName,                    
                    Location = model.CourseLocation,
                    TeeTime = model.CourseTeeTime
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Courses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CourseListItem> GetCourses()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Courses
                        .Select(
                            e =>
                                new CourseListItem
                                {
                                    CourseId = e.Id,
                                    CourseName = e.Name,
                                    CourseLocation = e.Location
                                }


                        );
                return query.ToArray();
            }
        }

        public CourseDetail GetCourseById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Courses
                    .Single(e => e.Id == id);
                return
                    new CourseDetail
                    {
                        CourseId = entity.Id,
                        CourseName = entity.Name,
                        CourseLocation = entity.Location,
                        CourseTeeTime = entity.TeeTime
                    };
            }

        }

        public bool UpdateCourse(CourseEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Courses
                        .Single(e => e.Id == model.CourseId );

                entity.Name = model.CourseName;
                entity.Id = model.CourseId;
                entity.TeeTime = model.CourseTeeTime;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCourse(int courseId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Courses
                        .Single(e => e.Id == courseId );

                ctx.Courses.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }


    }
}
