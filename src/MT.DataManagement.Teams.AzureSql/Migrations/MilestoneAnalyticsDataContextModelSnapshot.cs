﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MT.DataManagement.Teams.AzureSql;
using System;

namespace MT.DataManagement.Teams.AzureSql.Migrations
{
    [DbContext(typeof(MilestoneAnalyticsDataContext))]
    partial class MilestoneAnalyticsDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.CostMarker", b =>
                {
                    b.Property<string>("CostMarkerId");

                    b.Property<string>("TeamId");

                    b.Property<double>("Factor");

                    b.HasKey("CostMarkerId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("CostMarker");
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.Member", b =>
                {
                    b.Property<string>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.Repo", b =>
                {
                    b.Property<string>("RepoId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("RepoId");

                    b.ToTable("Repos");
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.Team", b =>
                {
                    b.Property<string>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DefaultMilestonesToTrack");

                    b.Property<string>("Organization");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.TeamMember", b =>
                {
                    b.Property<string>("TeamId");

                    b.Property<string>("MemberId");

                    b.Property<bool>("IncludeInReports");

                    b.HasKey("TeamId", "MemberId");

                    b.HasAlternateKey("MemberId", "TeamId");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.TeamRepo", b =>
                {
                    b.Property<string>("TeamId");

                    b.Property<string>("RepoId");

                    b.HasKey("TeamId", "RepoId");

                    b.HasAlternateKey("RepoId", "TeamId");

                    b.ToTable("TeamRepos");
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.CostMarker", b =>
                {
                    b.HasOne("MT.DataManagement.Teams.AzureSql.Model.Team")
                        .WithMany("CostMarkers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.TeamMember", b =>
                {
                    b.HasOne("MT.DataManagement.Teams.AzureSql.Model.Member", "Member")
                        .WithMany("TeamMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MT.DataManagement.Teams.AzureSql.Model.Team", "Team")
                        .WithMany("TeamMembers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MT.DataManagement.Teams.AzureSql.Model.TeamRepo", b =>
                {
                    b.HasOne("MT.DataManagement.Teams.AzureSql.Model.Repo", "Repo")
                        .WithMany("TeamRepos")
                        .HasForeignKey("RepoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MT.DataManagement.Teams.AzureSql.Model.Team", "Team")
                        .WithMany("TeamRepos")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
