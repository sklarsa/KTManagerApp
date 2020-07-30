﻿// <auto-generated />
using KillTeam.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KillTeam.Migrations
{
    [DbContext(typeof(KTUserContext))]
    partial class KTUserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("KillTeam.Models.Ability", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionDe");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionFr");

                    b.Property<string>("FactionId");

                    b.Property<string>("ModelId");

                    b.Property<string>("ModelProfileId");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.HasIndex("ModelId");

                    b.HasIndex("ModelProfileId");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("KillTeam.Models.AbilityDetail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbilityId");

                    b.Property<int>("Column");

                    b.Property<string>("ContentDe");

                    b.Property<string>("ContentEn");

                    b.Property<string>("ContentFr");

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.ToTable("AbilityDetail");
                });

            modelBuilder.Entity("KillTeam.Models.CostOverride", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("ModelProfileId");

                    b.Property<string>("WeaponId");

                    b.HasKey("Id");

                    b.HasIndex("ModelProfileId");

                    b.HasIndex("WeaponId");

                    b.ToTable("CostOverride");
                });

            modelBuilder.Entity("KillTeam.Models.Faction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.ToTable("Factions");
                });

            modelBuilder.Entity("KillTeam.Models.LevelCost", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<int>("Level");

                    b.Property<string>("ModelProfileId");

                    b.HasKey("Id");

                    b.HasIndex("ModelProfileId");

                    b.ToTable("LevelCost");
                });

            modelBuilder.Entity("KillTeam.Models.Member", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Convalescence");

                    b.Property<int>("Cost");

                    b.Property<int>("FleshWounds");

                    b.Property<int>("Level");

                    b.Property<string>("ModelProfileId");

                    b.Property<string>("Name");

                    b.Property<int>("Position");

                    b.Property<bool>("Recruit");

                    b.Property<bool>("Selected");

                    b.Property<string>("SpecialistId");

                    b.Property<string>("SubFactionId");

                    b.Property<string>("TeamId");

                    b.Property<int>("Xp");

                    b.HasKey("Id");

                    b.HasIndex("ModelProfileId");

                    b.HasIndex("SpecialistId");

                    b.HasIndex("SubFactionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("KillTeam.Models.MemberPower", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsGeneral");

                    b.Property<bool>("IsMaster");

                    b.Property<string>("MemberId");

                    b.Property<string>("MembrerId");

                    b.Property<string>("PowerId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("PowerId");

                    b.ToTable("MemberPowers");
                });

            modelBuilder.Entity("KillTeam.Models.MemberPsychic", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MemberId");

                    b.Property<string>("PsychicId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("PsychicId");

                    b.ToTable("MemberPsychics");
                });

            modelBuilder.Entity("KillTeam.Models.MemberSubFaction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MemberId");

                    b.Property<string>("SubFactionId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("SubFactionId");

                    b.ToTable("MemberSubFactions");
                });

            modelBuilder.Entity("KillTeam.Models.MemberTrait", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MemberId");

                    b.Property<string>("TraitId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("TraitId");

                    b.ToTable("MemberTraits");
                });

            modelBuilder.Entity("KillTeam.Models.MemberWarGearOption", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MemberId");

                    b.Property<string>("WarGearOptionId");

                    b.Property<string>("WeaponId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("WarGearOptionId");

                    b.HasIndex("WeaponId");

                    b.ToTable("MemberWarGearOptions");
                });

            modelBuilder.Entity("KillTeam.Models.MemberWeapon", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MemberId");

                    b.Property<string>("WeaponId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("WeaponId");

                    b.ToTable("MembreArme");
                });

            modelBuilder.Entity("KillTeam.Models.Model", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FactionId");

                    b.Property<string>("KeywordsDe");

                    b.Property<string>("KeywordsEn");

                    b.Property<string>("KeywordsFr");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attacks");

                    b.Property<int>("BallisticSkill");

                    b.Property<int>("Cost");

                    b.Property<bool>("IsCommander");

                    b.Property<int>("Leadership");

                    b.Property<int>("MaximumNumber");

                    b.Property<string>("ModelId");

                    b.Property<int>("Movement");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.Property<int>("NumberOfKnownPsychics");

                    b.Property<int>("NumberOfPsychicsDenialPerRound");

                    b.Property<int>("NumberOfPsychicsManifestationPerRound");

                    b.Property<int>("Save");

                    b.Property<int>("Strength");

                    b.Property<int>("Toughness");

                    b.Property<int>("WeaponSkill");

                    b.Property<int>("Wounds");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("ModelProfiles");
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfileSpecialist", b =>
                {
                    b.Property<string>("ModelProfileId");

                    b.Property<string>("SpecialistId");

                    b.HasKey("ModelProfileId", "SpecialistId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("ModelProfileSpecialist");
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfileSubFaction", b =>
                {
                    b.Property<string>("ModelProfileId");

                    b.Property<string>("SubFactionId");

                    b.HasKey("ModelProfileId", "SubFactionId");

                    b.HasIndex("SubFactionId");

                    b.ToTable("ModelProfileSubFaction");
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfileWeapon", b =>
                {
                    b.Property<string>("ModelProfileId");

                    b.Property<string>("WeaponId");

                    b.HasKey("ModelProfileId", "WeaponId");

                    b.HasIndex("WeaponId");

                    b.ToTable("ModelProfileWeapon");
                });

            modelBuilder.Entity("KillTeam.Models.ModelWeapon", b =>
                {
                    b.Property<string>("ModelId");

                    b.Property<string>("WeaponId");

                    b.HasKey("ModelId", "WeaponId");

                    b.HasIndex("WeaponId");

                    b.ToTable("ModelWeapon");
                });

            modelBuilder.Entity("KillTeam.Models.Phase", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.ToTable("Phases");
                });

            modelBuilder.Entity("KillTeam.Models.Power", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionDe");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionFr");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.Property<string>("PreviewsId");

                    b.Property<string>("SpecialistId");

                    b.HasKey("Id");

                    b.HasIndex("PreviewsId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("KillTeam.Models.Psychic", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Commander");

                    b.Property<string>("DescriptionDe");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionFr");

                    b.Property<int>("Dices");

                    b.Property<string>("ModelProfileId");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.Property<int>("WarpCharge");

                    b.HasKey("Id");

                    b.HasIndex("ModelProfileId");

                    b.ToTable("Psychics");
                });

            modelBuilder.Entity("KillTeam.Models.Specialist", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.ToTable("Specialists");
                });

            modelBuilder.Entity("KillTeam.Models.SubFaction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FactionId");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.ToTable("SubFactions");
                });

            modelBuilder.Entity("KillTeam.Models.Tactic", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aura");

                    b.Property<bool>("Commander");

                    b.Property<int>("Cost");

                    b.Property<string>("DescriptionDe");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionFr");

                    b.Property<string>("FactionId");

                    b.Property<int>("Level");

                    b.Property<string>("ModelProfileId");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.Property<string>("PhaseId");

                    b.Property<string>("SpecialistId");

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.HasIndex("ModelProfileId");

                    b.HasIndex("PhaseId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Tactics");
                });

            modelBuilder.Entity("KillTeam.Models.Team", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FactionId");

                    b.Property<int>("MaxPoints");

                    b.Property<string>("Name");

                    b.Property<int>("Position");

                    b.Property<bool>("Roster");

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("KillTeam.Models.Trait", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("DescriptionDe");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionFr");

                    b.Property<int>("Level");

                    b.Property<string>("ModelProfileId");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.HasIndex("ModelProfileId");

                    b.ToTable("Traits");
                });

            modelBuilder.Entity("KillTeam.Models.Version", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppVersion");

                    b.Property<string>("RulesVersion");

                    b.HasKey("Id");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("KillTeam.Models.WarGearOption", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Exclusion");

                    b.Property<int>("MaximumPerTeam");

                    b.Property<string>("ModelId");

                    b.Property<string>("ModelProfileId");

                    b.Property<string>("Operation");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.HasIndex("ModelProfileId");

                    b.ToTable("WarGearOption");
                });

            modelBuilder.Entity("KillTeam.Models.Weapon", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("DescriptionDe");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionFr");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("KillTeam.Models.WeaponProfile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArmourPenetration");

                    b.Property<string>("Damages");

                    b.Property<string>("DescriptionDe");

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionFr");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.Property<int>("Range");

                    b.Property<string>("ShotNumber");

                    b.Property<string>("Strength");

                    b.Property<string>("WeaponId");

                    b.Property<string>("WeaponTypeId");

                    b.HasKey("Id");

                    b.HasIndex("WeaponId");

                    b.HasIndex("WeaponTypeId");

                    b.ToTable("WeaponProfiles");
                });

            modelBuilder.Entity("KillTeam.Models.WeaponType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Index");

                    b.Property<string>("NameDe");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.HasKey("Id");

                    b.ToTable("WeaponTypes");
                });

            modelBuilder.Entity("KillTeam.Models.Ability", b =>
                {
                    b.HasOne("KillTeam.Models.Faction", "Faction")
                        .WithMany("Abilities")
                        .HasForeignKey("FactionId");

                    b.HasOne("KillTeam.Models.Model", "Model")
                        .WithMany("Abilities")
                        .HasForeignKey("ModelId");

                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("Abilities")
                        .HasForeignKey("ModelProfileId");
                });

            modelBuilder.Entity("KillTeam.Models.AbilityDetail", b =>
                {
                    b.HasOne("KillTeam.Models.Ability", "Ability")
                        .WithMany("Details")
                        .HasForeignKey("AbilityId");
                });

            modelBuilder.Entity("KillTeam.Models.CostOverride", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("CostOverrides")
                        .HasForeignKey("ModelProfileId");

                    b.HasOne("KillTeam.Models.Weapon", "Weapon")
                        .WithMany("CostOverrides")
                        .HasForeignKey("WeaponId");
                });

            modelBuilder.Entity("KillTeam.Models.LevelCost", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("LevelCosts")
                        .HasForeignKey("ModelProfileId");
                });

            modelBuilder.Entity("KillTeam.Models.Member", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("Members")
                        .HasForeignKey("ModelProfileId");

                    b.HasOne("KillTeam.Models.Specialist", "Specialist")
                        .WithMany("Members")
                        .HasForeignKey("SpecialistId");

                    b.HasOne("KillTeam.Models.SubFaction", "SubFaction")
                        .WithMany()
                        .HasForeignKey("SubFactionId");

                    b.HasOne("KillTeam.Models.Team", "Team")
                        .WithMany("Members")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("KillTeam.Models.MemberPower", b =>
                {
                    b.HasOne("KillTeam.Models.Member", "Member")
                        .WithMany("MemberPowers")
                        .HasForeignKey("MemberId");

                    b.HasOne("KillTeam.Models.Power", "Power")
                        .WithMany("MemberPowers")
                        .HasForeignKey("PowerId");
                });

            modelBuilder.Entity("KillTeam.Models.MemberPsychic", b =>
                {
                    b.HasOne("KillTeam.Models.Member", "Member")
                        .WithMany("MemberPsychics")
                        .HasForeignKey("MemberId");

                    b.HasOne("KillTeam.Models.Psychic", "Psychic")
                        .WithMany("MemberPsychics")
                        .HasForeignKey("PsychicId");
                });

            modelBuilder.Entity("KillTeam.Models.MemberSubFaction", b =>
                {
                    b.HasOne("KillTeam.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.HasOne("KillTeam.Models.SubFaction", "SubFaction")
                        .WithMany()
                        .HasForeignKey("SubFactionId");
                });

            modelBuilder.Entity("KillTeam.Models.MemberTrait", b =>
                {
                    b.HasOne("KillTeam.Models.Member", "Member")
                        .WithMany("MemberTraits")
                        .HasForeignKey("MemberId");

                    b.HasOne("KillTeam.Models.Trait", "Trait")
                        .WithMany("MemberTraits")
                        .HasForeignKey("TraitId");
                });

            modelBuilder.Entity("KillTeam.Models.MemberWarGearOption", b =>
                {
                    b.HasOne("KillTeam.Models.Member", "Member")
                        .WithMany("MemberWarGearOptions")
                        .HasForeignKey("MemberId");

                    b.HasOne("KillTeam.Models.WarGearOption", "WarGearOption")
                        .WithMany("MemberWarGearOptions")
                        .HasForeignKey("WarGearOptionId");

                    b.HasOne("KillTeam.Models.Weapon")
                        .WithMany("WarGearOptions")
                        .HasForeignKey("WeaponId");
                });

            modelBuilder.Entity("KillTeam.Models.MemberWeapon", b =>
                {
                    b.HasOne("KillTeam.Models.Member", "Member")
                        .WithMany("MemberWeapons")
                        .HasForeignKey("MemberId");

                    b.HasOne("KillTeam.Models.Weapon", "Weapon")
                        .WithMany("MemberWeapons")
                        .HasForeignKey("WeaponId");
                });

            modelBuilder.Entity("KillTeam.Models.Model", b =>
                {
                    b.HasOne("KillTeam.Models.Faction", "Faction")
                        .WithMany("Models")
                        .HasForeignKey("FactionId");
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfile", b =>
                {
                    b.HasOne("KillTeam.Models.Model", "Model")
                        .WithMany("ModelProfiles")
                        .HasForeignKey("ModelId");
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfileSpecialist", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("Specialists")
                        .HasForeignKey("ModelProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KillTeam.Models.Specialist", "Specialist")
                        .WithMany("ModelProfileSpecialists")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfileSubFaction", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("ModelProfileSubFactions")
                        .HasForeignKey("ModelProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KillTeam.Models.SubFaction", "SubFaction")
                        .WithMany()
                        .HasForeignKey("SubFactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KillTeam.Models.ModelProfileWeapon", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("ModelProfileWeapons")
                        .HasForeignKey("ModelProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KillTeam.Models.Weapon", "Weapon")
                        .WithMany("ModelProfileWeapons")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KillTeam.Models.ModelWeapon", b =>
                {
                    b.HasOne("KillTeam.Models.Model", "Model")
                        .WithMany("ModelWeapons")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KillTeam.Models.Weapon", "Weapon")
                        .WithMany("ModelWeapons")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KillTeam.Models.Power", b =>
                {
                    b.HasOne("KillTeam.Models.Power", "Previews")
                        .WithMany("Nexts")
                        .HasForeignKey("PreviewsId");

                    b.HasOne("KillTeam.Models.Specialist", "Specialist")
                        .WithMany("Powers")
                        .HasForeignKey("SpecialistId");
                });

            modelBuilder.Entity("KillTeam.Models.Psychic", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("Psychics")
                        .HasForeignKey("ModelProfileId");
                });

            modelBuilder.Entity("KillTeam.Models.SubFaction", b =>
                {
                    b.HasOne("KillTeam.Models.Faction", "Faction")
                        .WithMany()
                        .HasForeignKey("FactionId");
                });

            modelBuilder.Entity("KillTeam.Models.Tactic", b =>
                {
                    b.HasOne("KillTeam.Models.Faction", "Faction")
                        .WithMany("Tactics")
                        .HasForeignKey("FactionId");

                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("Tactics")
                        .HasForeignKey("ModelProfileId");

                    b.HasOne("KillTeam.Models.Phase", "Phase")
                        .WithMany("Tactics")
                        .HasForeignKey("PhaseId");

                    b.HasOne("KillTeam.Models.Specialist", "Specialist")
                        .WithMany("Tactics")
                        .HasForeignKey("SpecialistId");
                });

            modelBuilder.Entity("KillTeam.Models.Team", b =>
                {
                    b.HasOne("KillTeam.Models.Faction", "Faction")
                        .WithMany()
                        .HasForeignKey("FactionId");
                });

            modelBuilder.Entity("KillTeam.Models.Trait", b =>
                {
                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("Traits")
                        .HasForeignKey("ModelProfileId");
                });

            modelBuilder.Entity("KillTeam.Models.WarGearOption", b =>
                {
                    b.HasOne("KillTeam.Models.Model", "Model")
                        .WithMany("WarGearOptions")
                        .HasForeignKey("ModelId");

                    b.HasOne("KillTeam.Models.ModelProfile", "ModelProfile")
                        .WithMany("WarGearOptions")
                        .HasForeignKey("ModelProfileId");
                });

            modelBuilder.Entity("KillTeam.Models.WeaponProfile", b =>
                {
                    b.HasOne("KillTeam.Models.Weapon", "Weapon")
                        .WithMany("WeaponProfiles")
                        .HasForeignKey("WeaponId");

                    b.HasOne("KillTeam.Models.WeaponType", "WeaponType")
                        .WithMany("WeaponProfiles")
                        .HasForeignKey("WeaponTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
