using System;
using System.Collections.Generic;
using LiveScore.Models;
using Microsoft.EntityFrameworkCore;

namespace LiveScore.Data;

public partial class LiveScoreContext : DbContext
{
    public LiveScoreContext(DbContextOptions<LiveScoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cricket> Crickets { get; set; }

    public virtual DbSet<Kabaddi> Kabaddis { get; set; }

    public virtual DbSet<League> Leagues { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cricket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cricket")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_bin");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AwayLogo).HasMaxLength(500);
            entity.Property(e => e.AwayOver).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer1).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer10).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer10Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer10Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer10Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer11).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer11Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer11Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer11Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer1Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer1Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer1Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer2).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer2Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer2Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer2Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer3).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer3Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer3Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer3Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer4).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer4Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer4Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer4Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer5).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer5Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer5Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer5Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer6).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer6Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer6Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer6Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer7).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer7Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer7Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer7Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer8).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer8Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer8Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer8Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer9).HasMaxLength(45);
            entity.Property(e => e.AwayPlayer9Over).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer9Score).HasMaxLength(255);
            entity.Property(e => e.AwayPlayer9Wicket).HasMaxLength(255);
            entity.Property(e => e.AwayScore).HasMaxLength(45);
            entity.Property(e => e.AwayTeam).HasMaxLength(45);
            entity.Property(e => e.AwayWickets).HasMaxLength(45);
            entity.Property(e => e.Date).HasMaxLength(255);
            entity.Property(e => e.GameStatus).HasMaxLength(45);
            entity.Property(e => e.HomeLogo).HasMaxLength(500);
            entity.Property(e => e.HomeOver).HasMaxLength(45);
            entity.Property(e => e.HomePlayer1).HasMaxLength(45);
            entity.Property(e => e.HomePlayer10).HasMaxLength(45);
            entity.Property(e => e.HomePlayer10Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer10Over");
            entity.Property(e => e.HomePlayer10Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer10Score");
            entity.Property(e => e.HomePlayer10Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer10Wicket");
            entity.Property(e => e.HomePlayer11).HasMaxLength(45);
            entity.Property(e => e.HomePlayer11Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer11Over");
            entity.Property(e => e.HomePlayer11Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer11Score");
            entity.Property(e => e.HomePlayer11Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer11Wicket");
            entity.Property(e => e.HomePlayer1Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer1Over");
            entity.Property(e => e.HomePlayer1Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer1Score");
            entity.Property(e => e.HomePlayer1Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer1Wicket");
            entity.Property(e => e.HomePlayer2).HasMaxLength(45);
            entity.Property(e => e.HomePlayer2Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer2Over");
            entity.Property(e => e.HomePlayer2Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer2Score");
            entity.Property(e => e.HomePlayer2Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer2Wicket");
            entity.Property(e => e.HomePlayer3).HasMaxLength(45);
            entity.Property(e => e.HomePlayer3Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer3Over");
            entity.Property(e => e.HomePlayer3Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer3Score");
            entity.Property(e => e.HomePlayer3Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer3Wicket");
            entity.Property(e => e.HomePlayer4).HasMaxLength(45);
            entity.Property(e => e.HomePlayer4Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer4Over");
            entity.Property(e => e.HomePlayer4Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer4Score");
            entity.Property(e => e.HomePlayer4Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer4Wicket");
            entity.Property(e => e.HomePlayer5).HasMaxLength(45);
            entity.Property(e => e.HomePlayer5Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer5Over");
            entity.Property(e => e.HomePlayer5Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer5Score");
            entity.Property(e => e.HomePlayer5Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer5Wicket");
            entity.Property(e => e.HomePlayer6).HasMaxLength(45);
            entity.Property(e => e.HomePlayer6Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer6Over");
            entity.Property(e => e.HomePlayer6Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer6Score");
            entity.Property(e => e.HomePlayer6Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer6Wicket");
            entity.Property(e => e.HomePlayer7).HasMaxLength(45);
            entity.Property(e => e.HomePlayer7Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer7Over");
            entity.Property(e => e.HomePlayer7Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer7Score");
            entity.Property(e => e.HomePlayer7Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer7Wicket");
            entity.Property(e => e.HomePlayer8).HasMaxLength(45);
            entity.Property(e => e.HomePlayer8Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer8Over");
            entity.Property(e => e.HomePlayer8Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer8Score");
            entity.Property(e => e.HomePlayer8Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer8Wicket");
            entity.Property(e => e.HomePlayer9).HasMaxLength(45);
            entity.Property(e => e.HomePlayer9Over)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer9Over");
            entity.Property(e => e.HomePlayer9Score)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer9Score");
            entity.Property(e => e.HomePlayer9Wicket)
                .HasMaxLength(255)
                .HasColumnName(" HomePlayer9Wicket");
            entity.Property(e => e.HomeScore).HasMaxLength(45);
            entity.Property(e => e.HomeTeam).HasMaxLength(45);
            entity.Property(e => e.HomeWickets).HasMaxLength(45);
        });

        modelBuilder.Entity<Kabaddi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kabaddi");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AwayTeam).HasMaxLength(40);
            entity.Property(e => e.GameStatus).HasMaxLength(45);
            entity.Property(e => e.HomeTeam).HasMaxLength(40);
        });

        modelBuilder.Entity<League>(entity =>
        {
            entity.HasKey(e => e.TeamRank).HasName("PRIMARY");

            entity.ToTable("league");

            entity.Property(e => e.TeamRank)
                .ValueGeneratedNever()
                .HasColumnName("team_rank");
            entity.Property(e => e.Lost).HasColumnName("lost");
            entity.Property(e => e.Played).HasColumnName("played");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.TeamName)
                .HasMaxLength(50)
                .HasColumnName("team_name");
            entity.Property(e => e.Tied).HasColumnName("tied");
            entity.Property(e => e.Won).HasColumnName("won");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
