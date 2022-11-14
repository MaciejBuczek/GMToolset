using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMToolset.Services.Models.QuickBattleManager
{
    public class Participant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public bool IsMpApplicable { get; set; }
        public int MaxMp { get; set; }
        public int CurrentMp { get; set; }
        public bool IsStApplicable { get; set; }
        public int MaxSt { get; set; }
        public int CurrentSt { get; set; }
        public int Initiative { get; set; }
        public int DamagePerRound { get; set; }
        public string ExtraInfo { get; set; }
        public string Image { get; set; }
        public QuickSession QuickSession { get; set; }
    }
}
