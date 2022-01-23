using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class ApiAllEventsService : BaseService<EventListItemModel>, IAllEventsService
    {
        protected string _arenasUrl;
        protected string _battlegroundsUrl;
        protected string _dungeonsUrl;
        protected string _raidsUrl;
        protected string _usersUrl;
        protected List<EventListItemModel> _eventList;
        protected List<EventListItemModel> _pvpEventList;
        protected List<EventListItemModel> _pveEventList;
        public ApiAllEventsService()
        {
            _arenasUrl = ApiConstants.ApiArenasUrl;
            _battlegroundsUrl = ApiConstants.ApiBattlegroundsUrl;
            _dungeonsUrl = ApiConstants.ApiDungeonsUrl;
            _raidsUrl = ApiConstants.ApiRaidsUrl;
            _usersUrl = ApiConstants.ApiUsersUrl;
            _eventList = new List<EventListItemModel>();
            _pvpEventList = new List<EventListItemModel>();
            _pveEventList = new List<EventListItemModel>();
        }
        public async Task<ICollection<EventListItemModel>> ListAllAsync()
        {
            await GetStorageUserId();
            var characters = await ApiClient.GetAsync<ICollection<CharacterModel>>($"{_usersUrl}/{_userId}/{ApiConstants.Characters}");
            var arenas = await ApiClient.GetAsync<ICollection<ArenaModel>>(_arenasUrl);
            var battlegrounds = await ApiClient.GetAsync<ICollection<BattlegroundModel>>(_battlegroundsUrl);
            var dungeons = await ApiClient.GetAsync<ICollection<DungeonModel>>(_dungeonsUrl);
            var raids = await ApiClient.GetAsync<ICollection<RaidModel>>(_raidsUrl);

            GetSubscribedArenas(arenas, characters);
            GetSubscribedBattlegrounds(battlegrounds, characters);
            GetSubscribedDungeons(dungeons, characters);
            GetSubscribedRaids(raids, characters);

            return _eventList;
        }

        public async Task<ICollection<EventListItemModel>> ListAllPvpAsync()
        {
            var arenas = await ApiClient.GetAsync<ICollection<ArenaModel>>(_arenasUrl);
            var battlegrounds = await ApiClient.GetAsync<ICollection<BattlegroundModel>>(_battlegroundsUrl);

            GetTodaysArenas(arenas);
            GetTodaysBattlegrounds(battlegrounds);

            return _pvpEventList;
        }

        public async Task<ICollection<EventListItemModel>> ListAllPveAsync()
        {
            var dungeons = await ApiClient.GetAsync<ICollection<DungeonModel>>(_dungeonsUrl);
            var raids = await ApiClient.GetAsync<ICollection<RaidModel>>(_raidsUrl);

            GetTodaysDungeons(dungeons);
            GetTodaysRaids(raids);

            return _pveEventList;
        }

        private void GetSubscribedArenas(
            ICollection<ArenaModel> arenas,
            ICollection<CharacterModel> characters)
        {
            foreach (var arena in arenas)
            {
                foreach (var instanceCharacter in arena.Characters)
                {
                    foreach (var character in characters)
                    {
                        if (character.Id.Equals(instanceCharacter.Id) && arena.Date.Equals(DateTime.Now.Date))
                        {
                            var newEvent = new EventListItemModel
                            {
                                Id = arena.Id,
                                Name = $"{arena.Mode}v{arena.Mode}",
                                Date = arena.Date,
                                Type = nameof(arena)
                            };

                            _eventList.Add(newEvent);
                        }
                    }
                }
            }
        }

        private void GetSubscribedBattlegrounds(
            ICollection<BattlegroundModel> battlegrounds,
            ICollection<CharacterModel> characters)
        {
            foreach (var battleground in battlegrounds)
            {
                foreach (var instanceCharacter in battleground.Characters)
                {
                    foreach (var character in characters)
                    {
                        if (character.Id.Equals(instanceCharacter.Id) && battleground.Date.Equals(DateTime.Now.Date))
                        {
                            var newEvent = new EventListItemModel
                            {
                                Id = battleground.Id,
                                Name = battleground.InstanceName,
                                Date = battleground.Date,
                                Type = nameof(battleground)
                            };

                            _eventList.Add(newEvent);
                        }
                    }
                }
            }
        }

        private void GetSubscribedDungeons(
            ICollection<DungeonModel> dungeons,
            ICollection<CharacterModel> characters)
        {
            foreach (var dungeon in dungeons)
            {
                foreach (var instanceCharacter in dungeon.Characters)
                {
                    foreach (var character in characters)
                    {
                        if (character.Id.Equals(instanceCharacter.Id) && dungeon.Date.Equals(DateTime.Now.Date))
                        {
                            var newEvent = new EventListItemModel
                            {
                                Id = dungeon.Id,
                                Name = dungeon.InstanceName,
                                Date = dungeon.Date,
                                Type = nameof(dungeon)
                            };

                            _eventList.Add(newEvent);
                        }
                    }
                }
            }
        }

        private void GetSubscribedRaids(
            ICollection<RaidModel> raids,
            ICollection<CharacterModel> characters)
        {
            foreach (var raid in raids)
            {
                foreach (var instanceCharacter in raid.Characters)
                {
                    foreach (var character in characters)
                    {
                        if (character.Id.Equals(instanceCharacter.Id) && raid.Date.Equals(DateTime.Now.Date))
                        {
                            var newEvent = new EventListItemModel
                            {
                                Id = raid.Id,
                                Name = raid.InstanceName,
                                Date= raid.Date,
                                Type = nameof(raid)
                            };

                            _eventList.Add(newEvent);
                        }
                    }
                }
            }
        }

        private void GetTodaysArenas(ICollection<ArenaModel> arenas)
        {
            foreach(var arena in arenas)
            {
                if (arena.Date.Equals(DateTime.Now.Date))
                {
                    var newEvent = new EventListItemModel
                    {
                        Id = arena.Id,
                        Name = $"{arena.Mode}v{arena.Mode}",
                        Date = arena.Date
                    };

                    _pvpEventList.Add(newEvent);
                }
            }
        }

        private void GetTodaysBattlegrounds(ICollection<BattlegroundModel> battlegrounds)
        {
            foreach (var battleground in battlegrounds)
            {
                if (battleground.Date.Equals(DateTime.Now.Date))
                {
                    var newEvent = new EventListItemModel
                    {
                        Id = battleground.Id,
                        Name = battleground.InstanceName,
                        Date = battleground.Date
                    };

                    _pvpEventList.Add(newEvent);
                }
            }
        }

        private void GetTodaysDungeons(ICollection<DungeonModel> dungeons)
        {
            foreach (var dungeon in dungeons)
            {
                if (dungeon.Date.Equals(DateTime.Now.Date))
                {
                    var newEvent = new EventListItemModel
                    {
                        Id = dungeon.Id,
                        Name = dungeon.InstanceName,
                        Date = dungeon.Date
                    };

                    _pveEventList.Add(newEvent);
                }
            }
        }
        private void GetTodaysRaids(ICollection<RaidModel> raids)
        {
            foreach (var raid in raids)
            {
                if (raid.Date.Equals(DateTime.Now.Date))
                {
                    var newEvent = new EventListItemModel
                    {
                        Id = raid.Id,
                        Name = raid.InstanceName,
                        Date = raid.Date
                    };

                    _pveEventList.Add(newEvent);
                }
            }
        }
    }
}
