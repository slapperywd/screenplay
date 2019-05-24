using CSF.Screenplay.Abilities;

namespace Screenplay.Abilities
{
    public class SearchTheNews : Ability
    {
        private string _query = string.Empty;

        public void SearchNews(string query)
        {
            _query = query;
        }

        public int GetNewsCount()
        {
            switch (_query)
            {
                case "Belarus":
                    return 5;
                case "London":
                    return 10;
                default: return 0;
            }
        }
    }
}
