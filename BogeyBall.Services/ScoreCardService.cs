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
                    //Id = model.ScoreCardId,
                    PlayerList = model.PlayerList,
                    //TeeTime = model.CourseTeeTime,


                    ScoreOne = model.ScoreCardScoreOne,
                    ScoreTwo = model.ScoreCardScoreTwo,
                    ScoreThree = model.ScoreCardScoreThree,
                    ScoreFour = model.ScoreCardScoreFour,
                    ScoreFive = model.ScoreCardScoreFive,
                    ScoreSix = model.ScoreCardScoreSix,
                    ScoreSeven = model.ScoreCardScoreSeven,
                    ScoreEight = model.ScoreCardScoreEight,
                    ScoreNine = model.ScoreCardScoreNine,
                    ScoreTen = model.ScoreCardScoreTen,
                    ScoreEleven = model.ScoreCardScoreEleven,
                    ScoreTwelve = model.ScoreCardScoreTwelve,
                    ScoreThirteen = model.ScoreCardScoreThirteen,
                    ScoreFourteen = model.ScoreCardScoreFourteen,
                    ScoreFifteen = model.ScoreCardScoreFifteen,
                    ScoreSixteen = model.ScoreCardScoreSixteen,
                    ScoreSeventeen = model.ScoreCardScoreSeventeen,
                    ScoreEighteen = model.ScoreCardScoreEighteen,
                    
                };



            using (var ctx = new ApplicationDbContext())
            {
                ctx.ScoreCards.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //public bool CreateCourseTotal(int total)
        //{

        //}

        public IEnumerable<ScoreCardListItem> GetScoreCard()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .ScoreCards
                        .Select(
                            e =>
                                new ScoreCardListItem
                                {
                                    ScoreCardId = e.Id,
                                    ScoreCardCourseName = e.PlayerList.ToString(),
                                    ScoreCardPlayerName = e.CourseList.ToString()
                                }


                        );
                return query.ToArray();
            }
        }

        public ScoreCardDetail GetScoreCardById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .ScoreCards
                    .Single(e => e.Id == id);
                return
                    new ScoreCardDetail
                    {
                        ScoreCardId = entity.Id,
                        ScoreCardCourseName = entity.CourseList.ToString(),
                        ScoreCardPlayerName = entity.PlayerList.ToString(),
                        //CourseTeeTime = entity.TeeTime,
                        ScoreCardHoleOne = entity.HoleOne,
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
