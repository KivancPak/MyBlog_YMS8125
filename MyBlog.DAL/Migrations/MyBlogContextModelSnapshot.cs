﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBlog.DAL.Contexts;

namespace MyBlog.DAL.Migrations
{
    [DbContext(typeof(MyBlogContext))]
    partial class MyBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyBlog.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CategoryName = "Örnek Kategori" }
                    );
                });

            modelBuilder.Entity("MyBlog.Domain.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, AuthorId = 1, CategoryId = 1, Content = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus ut pretium elit. Praesent nec mi sit amet leo mollis venenatis. Vivamus scelerisque ipsum a nunc varius, in dictum justo lacinia. Sed sit amet dui quis nisl aliquam dictum ut ut urna. Nunc risus ante, accumsan et mattis sit amet, elementum a lorem. Quisque est ante, fermentum ac efficitur eu, bibendum non risus. Donec accumsan enim id fringilla accumsan. Mauris ligula velit, viverra ut tempus vel, ullamcorper eget nulla. Praesent commodo mauris nisi, in aliquam tortor varius sit amet. Curabitur porta venenatis nulla id pellentesque. Ut tellus erat, sodales eu fermentum at, sollicitudin in nibh.</p><p>Nullam molestie, lectus at congue interdum, odio augue faucibus magna, quis lacinia sem quam eu sem. Aenean vel finibus est. In semper semper convallis. Maecenas non tincidunt est. Suspendisse ut nulla vel est blandit bibendum a sed sem. Nam ut risus velit. Vestibulum ipsum tellus, ornare at gravida non, luctus nec turpis. Suspendisse potenti. Sed turpis libero, facilisis vitae justo et, sollicitudin lacinia massa. Nam ac ornare urna, id pulvinar ante.</p><p>Vivamus facilisis vehicula ante auctor convallis. Donec iaculis, enim vel fringilla rhoncus, dui quam congue erat, sit amet gravida tellus ligula quis mauris. Suspendisse aliquet metus nibh, non efficitur urna consequat a. Etiam efficitur quam a maximus scelerisque. Vestibulum pellentesque interdum faucibus. Suspendisse potenti. Vivamus ut dui eu tellus interdum maximus in quis eros. Aliquam molestie lacus odio, quis maximus risus cursus eget.</p>", Title = "Örnek Yazı 1" },
                        new { Id = 2, AuthorId = 1, CategoryId = 1, Content = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus ut pretium elit. Praesent nec mi sit amet leo mollis venenatis. Vivamus scelerisque ipsum a nunc varius, in dictum justo lacinia. Sed sit amet dui quis nisl aliquam dictum ut ut urna. Nunc risus ante, accumsan et mattis sit amet, elementum a lorem. Quisque est ante, fermentum ac efficitur eu, bibendum non risus. Donec accumsan enim id fringilla accumsan. Mauris ligula velit, viverra ut tempus vel, ullamcorper eget nulla. Praesent commodo mauris nisi, in aliquam tortor varius sit amet. Curabitur porta venenatis nulla id pellentesque. Ut tellus erat, sodales eu fermentum at, sollicitudin in nibh.</p><p>Nullam molestie, lectus at congue interdum, odio augue faucibus magna, quis lacinia sem quam eu sem. Aenean vel finibus est. In semper semper convallis. Maecenas non tincidunt est. Suspendisse ut nulla vel est blandit bibendum a sed sem. Nam ut risus velit. Vestibulum ipsum tellus, ornare at gravida non, luctus nec turpis. Suspendisse potenti. Sed turpis libero, facilisis vitae justo et, sollicitudin lacinia massa. Nam ac ornare urna, id pulvinar ante.</p><p>Vivamus facilisis vehicula ante auctor convallis. Donec iaculis, enim vel fringilla rhoncus, dui quam congue erat, sit amet gravida tellus ligula quis mauris. Suspendisse aliquet metus nibh, non efficitur urna consequat a. Etiam efficitur quam a maximus scelerisque. Vestibulum pellentesque interdum faucibus. Suspendisse potenti. Vivamus ut dui eu tellus interdum maximus in quis eros. Aliquam molestie lacus odio, quis maximus risus cursus eget.</p>", Title = "Örnek Yazı 2" }
                    );
                });

            modelBuilder.Entity("MyBlog.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Email = "yigith1@gmail.com", PasswordHash = "ACAWW+FoPY72mKNQrrsCs7UOJp4cV3TgKqVTLWmi+8XrzrEx9r9NCpjhenjoUoZWCg==", UserName = "yigith1@gmail.com", UserType = 1 }
                    );
                });

            modelBuilder.Entity("MyBlog.Domain.Entities.Post", b =>
                {
                    b.HasOne("MyBlog.Domain.Entities.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyBlog.Domain.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
