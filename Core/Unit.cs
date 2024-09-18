using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ages_of_Civilizations.Core
{
    internal class Unit
    {
        enum defenses
        {
           
        }
        enum unit_types
        {
            NO_ATTACK, GROUND_MELEE, GROUND_RANGED, NAVAL_MELEE, NAVAL_RANGED, FLYING_RANGED, FLYING_NOATTACK
        }

        // base fields
        private string name; private int unit_type; private int pop_size; private double range_value; private int cost; private int[] unit_types_list; 

        private double physical_attack_value, magical_attack_value, wrecking_attack_value, true_attack_value; // attack parameters

        private double physical_defense_value, magical_defense_value, wrecking_defense_value; // defense parameters

        private double movement_speed, attack_speed, health_recovery_speed, shield_recovery_speed; // speed parameters

        private double shield_value, parry_percentage, ignore_defense_value, damage_over_time_tick; // defensive parameters

        // damage modifiers
        private double infantry_damage_modifier, mythic_unit_damage_modifier, structure_damage_modifier, naval_unit_damage_modifier, flying_unit_damage_modifier, boss_unit_damage_modifier, champion_unit_damage_modifier;

        // getters and setters (field encapsulation)
        public string Name { get => name; }
        public int Unit_type { get => unit_type; }
        public int Pop_size { get => pop_size; set => pop_size = value; }
        public double Range_value { get => range_value; set => range_value = value; }
        public int Cost { get => cost; set => cost = value; }
        public int[] Unit_types_list { get => unit_types_list; }
        public double Physical_attack_value { get => physical_attack_value; set => physical_attack_value = value; }
        public double Magical_attack_value { get => magical_attack_value; set => magical_attack_value = value; }
        public double Wrecking_attack_value { get => wrecking_attack_value; set => wrecking_attack_value = value; }
        public double True_attack_value { get => true_attack_value; set => true_attack_value = value; }
        public double Physical_defense_value { get => physical_defense_value; set => physical_defense_value = value; }
        public double Magical_defense_value { get => magical_defense_value; set => magical_defense_value = value; }
        public double Wrecking_defense_value { get => wrecking_defense_value; set => wrecking_defense_value = value; }
        public double Movement_speed { get => movement_speed; set => movement_speed = value; }
        public double Attack_speed { get => attack_speed; set => attack_speed = value; }
        public double Health_recovery_speed { get => health_recovery_speed; set => health_recovery_speed = value; }
        public double Shield_recovery_speed { get => shield_recovery_speed; set => shield_recovery_speed = value; }
        public double Shield_value { get => shield_value; set => shield_value = value; }
        public double Parry_percentage { get => parry_percentage; set => parry_percentage = value; }
        public double Ignore_defense_value { get => ignore_defense_value; set => ignore_defense_value = value; }
        public double Damage_over_time_tick { get => damage_over_time_tick; set => damage_over_time_tick = value; }
        public double Infantry_damage_modifier { get => infantry_damage_modifier; set => infantry_damage_modifier = value; }
        public double Mythic_unit_damage_modifier { get => mythic_unit_damage_modifier; set => mythic_unit_damage_modifier = value; }
        public double Structure_damage_modifier { get => structure_damage_modifier; set => structure_damage_modifier = value; }
        public double Naval_unit_damage_modifier { get => naval_unit_damage_modifier; set => naval_unit_damage_modifier = value; }
        public double Flying_unit_damage_modifier { get => flying_unit_damage_modifier; set => flying_unit_damage_modifier = value; }
        public double Boss_unit_damage_modifier { get => boss_unit_damage_modifier; set => boss_unit_damage_modifier = value; }
        public double Champion_unit_damage_modifier { get => champion_unit_damage_modifier; set => champion_unit_damage_modifier = value; }      

        // constructors
        public Unit(string name, int unit_type, int cost, int pop_size, int[] unit_types_list) 
        {
            // base fields
            this.name = name;
            this.unit_type = unit_type;
            Cost = cost;
            Pop_size = pop_size;

            // no range unit
            Range_value = 0;

            // attack value fields
            Physical_attack_value = 0;
            Magical_attack_value = 0;  
            Wrecking_attack_value= 0;
            True_attack_value = 0;

            // defense value fields
            physical_defense_value = 0;
            magical_defense_value = 0;
            wrecking_defense_value = 0;

            // speed value fields
            Movement_speed = 1;
            Attack_speed = 1;
            Health_recovery_speed = 0;
            Shield_recovery_speed= 0;
            
            // defensive value fields
            Shield_value = 0;
            Parry_percentage = 0;
            Ignore_defense_value = 0;
            Damage_over_time_tick = 0;

            // damage modifier fields
            Infantry_damage_modifier = 0;
            Mythic_unit_damage_modifier = 0;
            Structure_damage_modifier = 0;
            Naval_unit_damage_modifier = 0;
            Flying_unit_damage_modifier = 0;
            Boss_unit_damage_modifier = 0;
            Champion_unit_damage_modifier = 0;

            this.unit_types_list = unit_types_list;
        }

        public Unit(string name, int unit_type, int cost, int pop_size, double range_value, int[] unit_types_list)
        {
            this.name = name;
            this.unit_type = unit_type;
            Cost = cost;
            Pop_size = pop_size;
            Range_value = range_value;

            // attack value fields
            Physical_attack_value = 0;
            Magical_attack_value = 0;
            Wrecking_attack_value = 0;
            True_attack_value = 0;

            // defense value fields
            physical_defense_value = 0;
            magical_defense_value = 0;
            wrecking_defense_value = 0;

            // speed value fields
            Movement_speed = 1;
            Attack_speed = 1;
            Health_recovery_speed = 0;
            Shield_recovery_speed = 0;

            // defensive value fields
            Shield_value = 0;
            Parry_percentage = 0;
            Ignore_defense_value = 0;
            Damage_over_time_tick = 0;

            // damage modifier fields
            Infantry_damage_modifier = 0;
            Mythic_unit_damage_modifier = 0;
            Structure_damage_modifier = 0;
            Naval_unit_damage_modifier = 0;
            Flying_unit_damage_modifier = 0;
            Boss_unit_damage_modifier = 0;
            Champion_unit_damage_modifier = 0;

            this.unit_types_list = unit_types_list;
        }

        


    }

   

}
