using BogeyBall.Data;
using BogeyBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Services
{
    public class ScoreCardService
    {
        private readonly Guid _userId;

        public ScoreCardService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateScoreCard(ScoreCardCreate model, int playerId)
        {
            var entity =
                new ScoreCard()
                {
                    //Id = model.ScoreCardId,
                    //ScoreCardId = model.ScoreCardId,
                    PlayerId = model.PlayerId,
                    CourseId = model.CourseId,
                    
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
                    
                    
                    HoleOne = model.CourseHoleOne,
                    HoleTwo = model.CourseHoleTwo,
                    HoleThree = model.CourseHoleThree,
                    HoleFour = model.CourseHoleFour,
                    HoleFive = model.CourseHoleFive,
                    HoleSix = model.CourseHoleSix,
                    HoleSeven = model.CourseHoleSeven,
                    HoleEight = model.CourseHoleEight,
                    HoleNine = model.CourseHoleNine,
                    HoleTen = model.CourseHoleTen,
                    HoleEleven = model.CourseHoleEleven,
                    HoleTwelve = model.CourseHoleTwelve,
                    HoleThirteen = model.CourseHoleThirteen,
                    HoleFourteen = model.CourseHoleFourteen,
                    HoleFifteen = model.CourseHoleFifteen,
                    HoleSixteen = model.CourseHoleSixteen,
                    HoleSeventeen = model.CourseHoleSeventeen,
                    HoleEighteen = model.CourseHoleEighteen,

                    Handicap = 

                    (model.CourseHoleOne + model.CourseHoleTwo + model.CourseHoleThree + model.CourseHoleFour +
                    model.CourseHoleFive + model.CourseHoleSix + model.CourseHoleSeven + model.CourseHoleEight +
                    model.CourseHoleNine + model.CourseHoleTen + model.CourseHoleEleven + model.CourseHoleTwelve +
                    model.CourseHoleThirteen + model.CourseHoleFourteen + model.CourseHoleFifteen + model.CourseHoleSixteen +
                    model.CourseHoleSeventeen + model.CourseHoleEighteen)
                    -
                    (model.ScoreCardScoreOne + model.ScoreCardScoreTwo + model.ScoreCardScoreThree +
                    model.ScoreCardScoreFour + model.ScoreCardScoreFive + model.ScoreCardScoreSix +
                    model.ScoreCardScoreSeven + model.ScoreCardScoreEight + model.ScoreCardScoreNine +
                    model.ScoreCardScoreTen + model.ScoreCardScoreEleven + model.ScoreCardScoreTwelve +
                    model.ScoreCardScoreThirteen + model.ScoreCardScoreFourteen + model.ScoreCardScoreFifteen +
                    model.ScoreCardScoreSixteen + model.ScoreCardScoreSeventeen + model.ScoreCardScoreEighteen)
                    
                    ,

                    
                    //HoleTotal = model.CourseHoleOne + model.CourseHoleTwo + model.CourseHoleThree + model.CourseHoleFour +
                    //model.CourseHoleFive + model.CourseHoleSix + model.CourseHoleSeven + model.CourseHoleEight +
                    //model.CourseHoleNine + model.CourseHoleTen + model.CourseHoleEleven + model.CourseHoleTwelve +
                    //model.CourseHoleThirteen + model.CourseHoleFourteen + model.CourseHoleFifteen + model.CourseHoleSixteen +
                    //model.CourseHoleSeventeen + model.CourseHoleEighteen,

                    

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
                                    ScoreCardId = e.ScoreCardId,
                                    ScoreCardCourseName = e.Course.Name,
                                    ScoreCardPlayerName = e.Player.FullName,
                                    //ScoreCardPlayerName = e.CourseList.ToList()
                                    ScoreCardHoleOne = e.HoleOne,
                                    ScoreCardHoleTwo = e.HoleTwo,
                                    ScoreCardHoleThree = e.HoleThree,
                                    ScoreCardHoleFour = e.HoleFour,
                                    ScoreCardHoleFive = e.HoleFive,
                                    ScoreCardHoleSix = e.HoleSix,
                                    ScoreCardHoleSeven = e.HoleSeven,
                                    ScoreCardHoleEight = e.HoleEight,
                                    ScoreCardHoleNine = e.HoleNine,

                                    ScoreCardHoleTen = e.HoleTen,
                                    ScoreCardHoleEleven = e.HoleEleven,
                                    ScoreCardHoleTwelve = e.HoleTwelve,
                                    ScoreCardHoleThirteen = e.HoleThirteen,
                                    ScoreCardHoleFourteen = e.HoleFourteen,
                                    ScoreCardHoleFifteen = e.HoleFifteen,
                                    ScoreCardHoleSixteen = e.HoleSixteen,
                                    ScoreCardHoleSeventeen = e.HoleSeventeen,
                                    ScoreCardHoleEighteen = e.HoleEighteen,


                                    ScoreCardScoreOne = e.ScoreOne,
                                    ScoreCardScoreTwo = e.ScoreTwo,
                                    ScoreCardScoreThree = e.ScoreThree,
                                    ScoreCardScoreFour = e.ScoreFour,
                                    ScoreCardScoreFive = e.ScoreFive,
                                    ScoreCardScoreSix = e.ScoreSix,
                                    ScoreCardScoreSeven = e.ScoreSeven,
                                    ScoreCardScoreEight = e.ScoreEight,
                                    ScoreCardScoreNine = e.ScoreNine,

                                    ScoreCardScoreTen = e.ScoreTen,
                                    ScoreCardScoreEleven = e.ScoreEleven,
                                    ScoreCardScoreTwelve = e.ScoreTwelve,
                                    ScoreCardScoreThirteen = e.ScoreThirteen,
                                    ScoreCardScoreFourteen = e.ScoreFourteen,
                                    ScoreCardScoreFifteen = e.ScoreFifteen,
                                    ScoreCardScoreSixteen = e.ScoreSixteen,
                                    ScoreCardScoreSeventeen = e.ScoreSeventeen,
                                    ScoreCardScoreEighteen = e.ScoreEighteen,

                                    ScoreCardScoreTotal = 
                                    
                                    (e.ScoreOne + e.ScoreTwo + e.ScoreThree + e.ScoreFour +
                                    e.ScoreFive + e.ScoreSix + e.ScoreSeven + e.ScoreEight +
                                    e.ScoreNine + e.ScoreTen + e.ScoreEleven + e.ScoreTwelve +
                                    e.ScoreThirteen + e.ScoreFourteen + e.ScoreFifteen + e.ScoreSixteen +
                                    e.ScoreSeventeen + e.ScoreEighteen),


                                    ScoreCardHandicap = 
                                    ((e.HoleOne + e.HoleTwo + e.HoleThree
                                    + e.HoleFour + e.HoleFive + e.HoleSix + e.HoleSeven + e.HoleEight
                                    + e.HoleNine + e.HoleTen + e.HoleEleven + e.HoleTwelve + e.HoleThirteen
                                    + e.HoleFourteen + e.HoleFifteen + e.HoleSixteen + e.HoleSeventeen + e.HoleEighteen))
                                    -
                                    (e.ScoreOne + e.ScoreTwo + e.ScoreThree + e.ScoreFour +
                                    e.ScoreFive + e.ScoreSix + e.ScoreSeven + e.ScoreEight +
                                    e.ScoreNine + e.ScoreTen + e.ScoreEleven + e.ScoreTwelve +
                                    e.ScoreThirteen + e.ScoreFourteen + e.ScoreFifteen + e.ScoreSixteen +
                                    e.ScoreSeventeen + e.ScoreEighteen)
                                    
        


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
                    .Single(e => e.ScoreCardId == id);
                return
                    new ScoreCardDetail
                    {
                        ScoreCardId = entity.ScoreCardId,
                        //ScoreCardCourseName = entity.
                        ScoreCardPlayerName = entity.Player.FullName,
                        ScoreCardCourseName = entity.Course.Name,
                        ScoreCardScoreTotal = (entity.ScoreOne + entity.ScoreTwo + entity.ScoreThree + entity.ScoreFour +
                                    entity.ScoreFive + entity.ScoreSix + entity.ScoreSeven + entity.ScoreEight +
                                    entity.ScoreNine + entity.ScoreTen + entity.ScoreEleven + entity.ScoreTwelve +
                                    entity.ScoreThirteen + entity.ScoreFourteen + entity.ScoreFifteen + entity.ScoreSixteen +
                                    entity.ScoreSeventeen + entity.ScoreEighteen),
                        //ScoreCardScoreTotal = entity.ScoreOne + entity.ScoreTwo + entity.ScoreThree +
                        //entity.ScoreFour + entity.ScoreFive + entity.ScoreSix + entity.ScoreSeven +
                        //entity.ScoreEight + entity.ScoreNine + entity.ScoreTen + entity.ScoreEleven +
                        //entity.ScoreTwelve + entity.ScoreThirteen + entity.ScoreFourteen + entity.ScoreFifteen +
                        //entity.ScoreSixteen + entity.ScoreSeventeen + entity.ScoreEighteen
                        //CourseTeeTime = entity.TeeTime,
                        //ScoreCardScoreOne = entity.ScoreOne,
                        //ScoreCardScoreTwo = entity.ScoreTwo,
                        //ScoreCardScoreThree = entity.ScoreThree,
                        //ScoreCardScoreFour = entity.ScoreFour,
                        //ScoreCardScoreFive = entity.ScoreFive,
                        //ScoreCardScoreSix = entity.ScoreSix,
                        //ScoreCardScoreSeven = entity.ScoreSeven,
                        //ScoreCardScoreEight = entity.ScoreEight,
                        //ScoreCardScoreNine = entity.ScoreNine,
                        //ScoreCardScoreTen = entity.ScoreTen,
                        //ScoreCardScoreEleven = entity.ScoreEleven,
                        //ScoreCardScoreTwelve = entity.ScoreTwelve,
                        //ScoreCardScoreThirteen = entity.ScoreThirteen,
                        //ScoreCardScoreFourteen = entity.ScoreFourteen,
                        //ScoreCardScoreFifteen = entity.ScoreFifteen,
                        //ScoreCardScoreSixteen = entity.ScoreSixteen,
                        //ScoreCardScoreSeventeen = entity.ScoreSeventeen,
                        //ScoreCardScoreEighteen = entity.ScoreEighteen,


                    };
            }

        }
        //not nessesary anymore
        public bool UpdateScoreCard(ScoreCardEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .ScoreCards
                        .Single(e => e.ScoreCardId == model.ScoreCardId);

                entity.ScoreCardId = model.ScoreCardId;
                //entity.PlayerList = model.ScoreCardPlayerName;
                //entity.CourseList = model.ScoreCardCourseName;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteScoreCard(int ScoreCardId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .ScoreCards
                        .Single(e => e.ScoreCardId == ScoreCardId);

                ctx.ScoreCards.Remove(entity);

                return ctx.SaveChanges() == 1;

            }
        }
    }
}
