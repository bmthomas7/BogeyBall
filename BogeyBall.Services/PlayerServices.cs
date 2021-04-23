﻿using BogeyBall.Data;
using BogeyBall.Models;
using BogeyBall.Models.PlayerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Services
{
    public class PlayerService
    {
        private readonly Guid _userId;

        public PlayerService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePlayer(PlayerCreate model)
        {
            var entity =
                new Player()
                {
                    OwnerId = _userId,
                    FullName = model.PlayerName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Players.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PlayerListItem> GetPlayers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Players
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new PlayerListItem
                                {
                                    PlayerId = e.Id,
                                    PlayerName = e.FullName

                                }


                        );
                return query.ToArray();
            }
        }

        public PlayerDetail GetPlayerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Players
                    .Single(e => e.Id == id && e.OwnerId == _userId);
                return
                    new PlayerDetail
                    {
                        PlayerId = entity.Id,
                        PlayerName = entity.FullName
                    };
            }

        }

        public bool UpdatePlayer(PlayerEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Players
                        .Single(e => e.Id == model.PlayerId && e.OwnerId == _userId);

                entity.Id = model.PlayerId;
                entity.FullName = model.PlayerName;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePlayer(int playerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Players
                        .Single(e => e.Id == playerId && e.OwnerId == _userId);

                ctx.Players.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }


    }
}
