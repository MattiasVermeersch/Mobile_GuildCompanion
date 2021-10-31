using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Services
{
    public class CharactersService
    {
        private List<string> characters;

        public List<string> GetCharacters()
        {
            characters = new List<string>
            {
                "Character 1",
                "Character 2",
                "Character 3"
            };

            return characters;
        }
    }
}
