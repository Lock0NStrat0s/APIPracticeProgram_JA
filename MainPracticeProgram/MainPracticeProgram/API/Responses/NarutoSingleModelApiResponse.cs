using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPracticeProgram.API.Responses
{
  

    public class Age
    {
        [JsonProperty("Part I")]
        public string PartI { get; set; }

        [JsonProperty("Part II")]
        public string PartII { get; set; }

        [JsonProperty("Academy Graduate")]
        public string AcademyGraduate { get; set; }

        [JsonProperty("Chunin Promotion")]
        public string ChuninPromotion { get; set; }
    }

    public class Debut
    {
        public string manga { get; set; }
        public string anime { get; set; }
        public string novel { get; set; }
        public string movie { get; set; }
        public string game { get; set; }
        public string ova { get; set; }
        public string appearsIn { get; set; }
    }

    public class Family
    {
        public string father { get; set; }
        public string mother { get; set; }
        public string brother { get; set; }
        public string niece { get; set; }
    }

    public class Height
    {
        [JsonProperty("Part I")]
        public string PartI { get; set; }

        [JsonProperty("Part II")]
        public string PartII { get; set; }
    }

    public class NinjaRank
    {
        [JsonProperty("Part I")]
        public string PartI { get; set; }
    }

    public class Personal
    {
        public string birthdate { get; set; }
        public string sex { get; set; }
        public Age age { get; set; }
        public string status { get; set; }
        public Height height { get; set; }
        public Weight weight { get; set; }
        public string bloodType { get; set; }
        public List<string> kekkeiGenkai { get; set; }
        public List<string> classification { get; set; }
        public string occupation { get; set; }
        public List<string> affiliation { get; set; }
        public List<string> team { get; set; }
        public List<string> partner { get; set; }
        public string clan { get; set; }
        public List<string> titles { get; set; }
    }

    public class Rank
    {
        public NinjaRank ninjaRank { get; set; }
        public string ninjaRegistration { get; set; }
    }

    public class NarutoSingleModelApiResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<string> images { get; set; }
        public Debut debut { get; set; }
        public Family family { get; set; }
        public List<string> jutsu { get; set; }
        public List<string> natureType { get; set; }
        public Personal personal { get; set; }
        public Rank rank { get; set; }
        public List<string> tools { get; set; }
        public VoiceActors voiceActors { get; set; }
    }

    public class VoiceActors
    {
        public List<string> japanese { get; set; }
        public List<string> english { get; set; }
    }

    public class Weight
    {
        [JsonProperty("Part I")]
        public string PartI { get; set; }

        [JsonProperty("Part II")]
        public string PartII { get; set; }
    }


}
