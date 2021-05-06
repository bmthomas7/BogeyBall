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
                    //Id = model.CourseId,
                    Name = model.CourseName,
                    Location = model.CourseLocation,
                    TeeTime = model.CourseTeeTime,
                    //HoleOne = model.CourseHoleOne,
                    //HoleTwo = model.CourseHoleTwo,
                    //HoleThree = model.CourseHoleThree,
                    //HoleFour = model.CourseHoleFour,
                    //HoleFive = model.CourseHoleFive,
                    //HoleSix = model.CourseHoleSix,
                    //HoleSeven = model.CourseHoleSeven,
                    //HoleEight = model.CourseHoleEight,
                    //HoleNine = model.CourseHoleNine,
                    //HoleTen = model.CourseHoleTen,
                    //HoleEleven = model.CourseHoleEleven,
                    //HoleTwelve = model.CourseHoleTwelve,
                    //HoleThirteen = model.CourseHoleThirteen,
                    //HoleFourteen = model.CourseHoleFourteen,
                    //HoleFifteen = model.CourseHoleFifteen,
                    //HoleSixteen = model.CourseHoleSixteen,
                    //HoleSeventeen = model.CourseHoleSeventeen,
                    //HoleEighteen = model.CourseHoleEighteen,
                    //HoleTotal = model.CourseHoleOne + model.CourseHoleTwo + model.CourseHoleThree + model.CourseHoleFour +
                    //model.CourseHoleFive + model.CourseHoleSix + model.CourseHoleSeven + model.CourseHoleEight +
                    //model.CourseHoleNine + model.CourseHoleTen + model.CourseHoleEleven + model.CourseHoleTwelve +
                    //model.CourseHoleThirteen + model.CourseHoleFourteen + model.CourseHoleFifteen + model.CourseHoleSixteen +
                    //model.CourseHoleSeventeen + model.CourseHoleEighteen
                };



            using (var ctx = new ApplicationDbContext())
            {
                ctx.Courses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //public bool CreateCourseTotal(int total)
        //{

        //}

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
                                    CourseId = e.CourseId,
                                    CourseName = e.Name,
                                    CourseLocation = e.Location,
                                    //CourseHoleTotal = e.HoleTotal
                                    //(e.HoleOne + e.HoleTwo + e.HoleThree
                                    //+ e.HoleFour + e.HoleFive + e.HoleSix + e.HoleSeven + e.HoleEight
                                    //+ e.HoleNine + e.HoleTen + e.HoleEleven + e.HoleTwelve + e.HoleThirteen
                                    //+ e.HoleFourteen + e.HoleFifteen + e.HoleSixteen + e.HoleSeventeen + e.HoleEighteen)
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
                    .Single(e => e.CourseId == id);
                return
                    new CourseDetail
                    {
                        CourseId = entity.CourseId,
                        CourseName = entity.Name,
                        CourseLocation = entity.Location,
                        //CourseTeeTime = entity.TeeTime,
                        //CourseHoleOne = entity.HoleOne,
                        //CourseHoleTwo = entity.HoleTwo,
                        //CourseHoleThree = entity.HoleThree,
                        //CourseHoleFour = entity.HoleFour,
                        //CourseHoleFive = entity.HoleFive,
                        //CourseHoleSix = entity.HoleSix,
                        //CourseHoleSeven = entity.HoleSeven,
                        //CourseHoleEight = entity.HoleEight,
                        //CourseHoleNine = entity.HoleNine,
                        //CourseHoleTen = entity.HoleTen,
                        //CourseHoleEleven = entity.HoleEleven,
                        //CourseHoleTwelve = entity.HoleTwelve,
                        //CourseHoleThirteen = entity.HoleThirteen,
                        //CourseHoleFourteen = entity.HoleFourteen,
                        //CourseHoleFifteen = entity.HoleFifteen,
                        //CourseHoleSixteen = entity.HoleSixteen,
                        //CourseHoleSeventeen = entity.HoleSeventeen,
                        //CourseHoleEighteen = entity.HoleEighteen,
                        //CourseHoleTotal = entity.HoleOne,
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
                        .Single(e => e.CourseId == model.CourseId );

                entity.Name = model.CourseName;
                entity.CourseId = model.CourseId;
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
                        .Single(e => e.CourseId == courseId );

                ctx.Courses.Remove(entity);
                                                     
                return ctx.SaveChanges() == 1;                    
                    
            }
        }


    }
}
