﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuy.Repositorio.Context;

namespace QuickBuy.Repositorio.Migrations
{
    [DbContext(typeof(QuickBuyContext))]
    [Migration("20200805195118_CargaPaymentForm")]
    partial class CargaPaymentForm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBuy.Dominio.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(19,4)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdressNumber")
                        .IsRequired();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CompleteAddress")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("ExpectedDeliveryDate");

                    b.Property<int>("PaymentFormId");

                    b.Property<DateTime>("RequestDate");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PaymentFormId");

                    b.HasIndex("UserId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entities.ValuableObject.PaymentForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PaymentForm");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Forma de pagamento Boleto",
                            Name = "Boleto"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Forma de pagamento Cartão de Crédito",
                            Name = "Cartão de Crédito"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Forma de pagamento Depósito",
                            Name = "Depósito"
                        });
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entities.OrderItem", b =>
                {
                    b.HasOne("QuickBuy.Dominio.Entities.Request")
                        .WithMany("OrderItems")
                        .HasForeignKey("RequestId");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entities.Request", b =>
                {
                    b.HasOne("QuickBuy.Dominio.Entities.ValuableObject.PaymentForm", "PaymentForm")
                        .WithMany()
                        .HasForeignKey("PaymentFormId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuickBuy.Dominio.Entities.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
