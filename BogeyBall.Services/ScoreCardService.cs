using BogeyBall.Data;
using BogeyBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Services
{
    class ScoreCardService
    {
        private readonly Guid _userId;

        public ScoreCardService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateScoreCard(ScoreCardCreate model)
        {
            var entity =
                new ScoreCard()
                {
                    //Id = model.CourseId,
                    Id = model.ScoreCardId,
                    fullname = model.,
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
                    //HoleEighteen = model.CourseHoleEighteen
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
                        CourseTeeTime = entity.TeeTime,
                        CourseHoleOne = entity.HoleOne,
                        CourseHoleTwo = entity.HoleTwo,
                        CourseHoleThree = entity.HoleThree,
                        CourseHoleFour = entity.HoleFour,
                        CourseHoleFive = entity.HoleFive,
                        CourseHoleSix = entity.HoleSix,
                        CourseHoleSeven = entity.HoleSeven,
                        CourseHoleEight = entity.HoleEight,
                        CourseHoleNine = entity.HoleNine,
                        CourseHoleTen = entity.HoleTen,
                        CourseHoleEleven = entity.HoleEleven,
                        CourseHoleTwelve = entity.HoleTwelve,
                        CourseHoleThirteen = entity.HoleThirteen,
                        CourseHoleFourteen = entity.HoleFourteen,
                        CourseHoleFifteen = entity.HoleFifteen,
                        CourseHoleSixteen = entity.HoleSixteen,
                        CourseHoleSeventeen = entity.HoleSeventeen,
                        CourseHoleEighteen = entity.HoleEighteen
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
                        .Single(e => e.Id == model.CourseId);

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
                        .Single(e => e.Id == courseId);

                ctx.Courses.Remove(entity);

                return ctx.SaveChanges() == 1;

            }
        }
    }
}
