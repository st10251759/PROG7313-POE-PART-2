USE [master]
GO
/****** Object:  Database [ArgiConnectEnergyBD]    Script Date: 2025/05/12 17:38:15 ******/
CREATE DATABASE [ArgiConnectEnergyBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ArgiConnectEnergyBD', FILENAME = N'C:\Users\chett\ArgiConnectEnergyBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ArgiConnectEnergyBD_log', FILENAME = N'C:\Users\chett\ArgiConnectEnergyBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ArgiConnectEnergyBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET  MULTI_USER 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET QUERY_STORE = OFF
GO
USE [ArgiConnectEnergyBD]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Discriminator] [nvarchar](21) NOT NULL,
	[Firstname] [nvarchar](max) NULL,
	[Lastname] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Location] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2025/05/12 17:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Category] [nvarchar](max) NOT NULL,
	[ProductionDate] [datetime2](7) NOT NULL,
	[ImageUrlPath] [nvarchar](max) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250505131330_RoleBasedAccessMigration', N'9.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250506142712_AddedProductTable', N'9.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250506143618_UpdatedUserApplicationTable', N'9.0.4')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4e2ac5d4-2309-4286-90eb-8f7557f9dbe8', N'Farmer', N'FARMER', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8bb0e0ec-2a7f-4c24-b6ee-e0111f0fa1d5', N'Admin', N'ADMIN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e30a0f94-f6dd-4eaa-84a6-3c28eadc984f', N'Employee', N'EMPLOYEE', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'469421e4-cbb9-4666-a750-e6cc65aff303', N'4e2ac5d4-2309-4286-90eb-8f7557f9dbe8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4e0ce70f-201d-4d3d-a695-c2a280973aa9', N'4e2ac5d4-2309-4286-90eb-8f7557f9dbe8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7378fc1c-576a-44b6-93f5-152bb662b92f', N'4e2ac5d4-2309-4286-90eb-8f7557f9dbe8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a98dd9e9-d165-44a0-815c-884426ab092c', N'4e2ac5d4-2309-4286-90eb-8f7557f9dbe8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ec7776d2-0816-4c28-95f9-2eb74306bdde', N'4e2ac5d4-2309-4286-90eb-8f7557f9dbe8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bfd1d226-ee5f-4aeb-a32a-45d5ad748286', N'8bb0e0ec-2a7f-4c24-b6ee-e0111f0fa1d5')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1641917b-bdee-4e88-a287-8b96bfe6d254', N'e30a0f94-f6dd-4eaa-84a6-3c28eadc984f')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'29c3ffa9-c943-46d5-924b-8b1ef97fe59b', N'e30a0f94-f6dd-4eaa-84a6-3c28eadc984f')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'33fe726d-2542-4afd-8d5c-042ce5e9a998', N'e30a0f94-f6dd-4eaa-84a6-3c28eadc984f')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3a02e5df-b3e6-4648-9fe7-1f6f5b9198a0', N'e30a0f94-f6dd-4eaa-84a6-3c28eadc984f')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee2f4f05-dcaa-40ee-9110-fac65b9e1092', N'e30a0f94-f6dd-4eaa-84a6-3c28eadc984f')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'1641917b-bdee-4e88-a287-8b96bfe6d254', N'ApplicationUser', N'Ayanda', N'Khumalo', N'ayanda.khumalo@example.com', N'AYANDA.KHUMALO@EXAMPLE.COM', N'ayanda.khumalo@example.com', N'AYANDA.KHUMALO@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEJ+mY/9/rOwwGfZ0DlzZvS3iVeFV+4/0+utDqSM0MhljNeT3SSkr0pj28WEOodM++w==', N'INLEDKCJWKYTAU7UR2ZDINHL7IFLQRGE', N'5522da9f-1f5a-43f2-8fc4-ea827693a344', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'29c3ffa9-c943-46d5-924b-8b1ef97fe59b', N'ApplicationUser', N' Rajesh', N'Reddy', N'rajesh.reddy@example.com', N'RAJESH.REDDY@EXAMPLE.COM', N'rajesh.reddy@example.com', N'RAJESH.REDDY@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEF9B7WNT0uEy6C2HYin6OXiZ1lr9Ms7SBLWz7KmcAIWEyOQWAoq2boQr/7ClG02Umg==', N'6SUF2U6GSHZJLYBDFRSL5VGM25JEDAVJ', N'0deec307-20bb-411d-97eb-ca5d4c16a871', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'33fe726d-2542-4afd-8d5c-042ce5e9a998', N'ApplicationUser', N'Linda', N'van der Merwe', N'linda.vdmerwe@example.com', N'LINDA.VDMERWE@EXAMPLE.COM', N'linda.vdmerwe@example.com', N'LINDA.VDMERWE@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEIpEfLdIZuW4sNAj/T471GR1Qe8QuA4Ps/QyDLgrzPQwEmmO+ItICE6zm3CLWOZ6VA==', N'45V36HLIRXL4EEVLI44TEMI4NRH2FBKV', N'5f77d974-4072-4eb7-a157-f47ecd3d519e', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'3a02e5df-b3e6-4648-9fe7-1f6f5b9198a0', N'ApplicationUser', N'Chen', N'Liu', N'chen.liu@example.com', N'CHEN.LIU@EXAMPLE.COM', N'chen.liu@example.com', N'CHEN.LIU@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEBxtzi79ZDUJmBDedirwZ0qLo8aMrDsNS8b/ICZ8Rc6NlVEbOF3ZrxX2CU9v+A6aFA==', N'E564JGSCVLVCA5TVMRD64SHDY636LS2J', N'772f8c77-5cac-46ad-b99f-350557925b2f', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'469421e4-cbb9-4666-a750-e6cc65aff303', N'ApplicationUser', N'Priya', N'Naidoo', N'priya.naidoo@example.com', N'PRIYA.NAIDOO@EXAMPLE.COM', N'priya.naidoo@example.com', N'PRIYA.NAIDOO@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAELzx4AHX2COC8b7tjnfJfvwv2OydYhzTKHEisB6vpUQo8O4s+ZWPLgaYIi3cwE6V9A==', N'Q2UXPNIFCVLTDHJO4YFXZIOOOSVR5YIC', N'932ce762-9999-4747-aa99-be97753bd354', N'0823456787', 0, 0, NULL, 1, 0, N'Durban')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'4e0ce70f-201d-4d3d-a695-c2a280973aa9', N'ApplicationUser', N'Emily', N'Smith', N'emily.smith@example.com', N'EMILY.SMITH@EXAMPLE.COM', N'emily.smith@example.com', N'EMILY.SMITH@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAENoN7n4ZkU6GhUyofmpMkUbUMHVvxVlalmWjzWn01kvcWfjqbonbRyImeeiWOSMZuA==', N'K5GACEOLIPPICEXTFL4ENDLCERJC2IFD', N'6664c443-4403-421c-a915-94594f7617a1', N'0843456789', 0, 0, NULL, 1, 0, N'Cape Town')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'7378fc1c-576a-44b6-93f5-152bb662b92f', N'ApplicationUser', N'Thandiwe', N'Mkhize', N'thandiwe.mkhize@example.com', N'THANDIWE.MKHIZE@EXAMPLE.COM', N'thandiwe.mkhize@example.com', N'THANDIWE.MKHIZE@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEDEuOTg2gxSW/ZgCAxjMekpTEk3epBy2pbTGaMsc82vXSnokMdfEBr2WAucr4K8v8Q==', N'5NSIMKCXPJNBMTVEMY7MYYKW4WIMRQPH', N'4ddfa6be-a148-413a-916e-8a00f3c48475', N'0832345678', 0, 0, NULL, 1, 0, N'Pietermaritzburg')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'a98dd9e9-d165-44a0-815c-884426ab092c', N'ApplicationUser', N'Sipho', N'Dlamini', N'sipho.dlamini@example.com', N'SIPHO.DLAMINI@EXAMPLE.COM', N'sipho.dlamini@example.com', N'SIPHO.DLAMINI@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAECIY4GsfYo4tK6dVah1+x3oZrL6oPRjhHCqrF84DTmBKcst4TmLFacX9lBOf+rCZgg==', N'ADMA7BPRSMP26ZMMDUHKR4RXUJXKBLTQ', N'e0e7d277-bc63-4b45-98f4-0dd53727c646', N'0854567894', 0, 0, NULL, 1, 0, N'Johannesburg')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'bfd1d226-ee5f-4aeb-a32a-45d5ad748286', N'ApplicationUser', N'Admin', N'User', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAELVGF2XeUDJIOCMAS7pR0v29Krahhmkf08wVgDxPw+8pF1si/zLNhY9p54oH/5Atnw==', N'K3QVHD5QLABLM6OLSTIHF5VQVHNLP7IN', N'f7ec6728-4182-41ea-9461-5ba6d8d1bedd', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'ec7776d2-0816-4c28-95f9-2eb74306bdde', N'ApplicationUser', N'Aarav', N'Patel', N'aarav.patel@example.com', N'AARAV.PATEL@EXAMPLE.COM', N'aarav.patel@example.com', N'AARAV.PATEL@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEIFsEK+/vRc+6C6+upKzHb6+Rn887vg11lfD0DSdi6cyJaOTCMBg5a9O6Eb6jU+Ocg==', N'BPSUJBXVIITXVOYYNB3LZ3ZERNZF7Q5M', N'7a9b4f8a-29c6-4775-988e-7ca6ca9477ce', N'0821234567', 0, 0, NULL, 1, 0, N'Durban')
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Firstname], [Lastname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Location]) VALUES (N'ee2f4f05-dcaa-40ee-9110-fac65b9e1092', N'ApplicationUser', N'Mohammed', N'Al-Karim', N'mohammed.alkarim@example.com', N'MOHAMMED.ALKARIM@EXAMPLE.COM', N'mohammed.alkarim@example.com', N'MOHAMMED.ALKARIM@EXAMPLE.COM', 0, N'AQAAAAIAAYagAAAAEIwqgoXuykK4R6xndPMH3fukTsM7rPJ8FwgfzdnNYMLVORR3iq4EeYt/c6Gcb7fG3g==', N'H4YZVZNHHEBZ6WB6XQVEPD4PMFSQSSJ5', N'917cac35-ace7-433a-8704-2da22f88e44a', NULL, 0, 0, NULL, 1, 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4002, N'SolarMax Irrigation 3000', N'High-efficiency solar-powered irrigation system', N'Solar Irrigation', CAST(N'2025-05-13T00:00:00.0000000' AS DateTime2), N'/images/products/7d806a08-1c52-41d7-a033-bc81c3d050cb_Solar Irrigation Systems 1.png', N'ec7776d2-0816-4c28-95f9-2eb74306bdde')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4003, N'WindPro Turbine X', N'Compact wind turbine for small-scale farms', N'Wind Turbines', CAST(N'2025-05-22T00:00:00.0000000' AS DateTime2), N'/images/products/7b951251-d17b-43ec-bcd2-d23c9ea4f09f_Wind Turbines 1.png', N'ec7776d2-0816-4c28-95f9-2eb74306bdde')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4004, N'BioGen Compost Unit', N'Biogas solution converting waste to energy', N'Biogas Solutions', CAST(N'2025-04-15T00:00:00.0000000' AS DateTime2), N'/images/products/2e94b1fb-0546-440a-b07f-e5cbb5985d7e_Biogas Solutions 1.png', N'ec7776d2-0816-4c28-95f9-2eb74306bdde')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4005, N'SunPanel 500W', N'Durable solar panel with 500W output', N'Solar Panels', CAST(N'2025-02-14T00:00:00.0000000' AS DateTime2), N'/images/products/d94a9048-d4c9-41cb-bcd3-1058a134571e_Solar Panels 1.png', N'ec7776d2-0816-4c28-95f9-2eb74306bdde')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4006, N'EcoStorage Battery Pack', N'Energy storage system with 10kWh capacity', N'Energy Storage', CAST(N'2025-05-12T00:00:00.0000000' AS DateTime2), N'/images/products/a7770675-a0c0-465a-8f92-3ec8eb32d9b6_Energy Storage Systems 1.png', N'ec7776d2-0816-4c28-95f9-2eb74306bdde')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4007, N'AquaSolar Irrigator', N'Solar-powered irrigation tailored for African terrains', N'Solar Irrigation', CAST(N'2024-03-10T00:00:00.0000000' AS DateTime2), N'/images/products/30ac75bf-3e42-4e26-a44d-e72f42f76527_Solar Irrigation Systems 2.png', N'7378fc1c-576a-44b6-93f5-152bb662b92f')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4008, N'WindLite 200', N'Lightweight wind turbine for moderate wind zones', N'Wind Turbines', CAST(N'2025-02-11T00:00:00.0000000' AS DateTime2), N'/images/products/18de92d5-571d-482e-bd96-6dff7aebf751_Wind Turbines 2.png', N'7378fc1c-576a-44b6-93f5-152bb662b92f')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4009, N'BioHarvest Digester', N'Biogas solution for organic waste management', N'Biogas Solutions', CAST(N'2024-11-07T00:00:00.0000000' AS DateTime2), N'/images/products/f8372bc4-5e16-4eec-b3b6-5ef1ce14fd99_Biogas Solutions 2.png', N'7378fc1c-576a-44b6-93f5-152bb662b92f')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4010, N'SunRay Panel 400W', N'Efficient solar panel suitable for small farms', N'Solar Panels', CAST(N'2025-05-14T00:00:00.0000000' AS DateTime2), N'/images/products/bcbaec32-cb28-4a2c-aed2-926777119fbf_Solar Panels 4.png', N'7378fc1c-576a-44b6-93f5-152bb662b92f')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4011, N'PowerVault Storage Unit', N'Compact energy storage with smart monitoring', N'Energy Storage', CAST(N'2025-05-12T00:00:00.0000000' AS DateTime2), N'/images/products/801bb5ef-b476-4133-bef0-5fe6facfc914_Energy Storage Systems 3.png', N'7378fc1c-576a-44b6-93f5-152bb662b92f')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4012, N'IrrigaSun Pro', N'Advanced solar irrigation with automated controls', N'Solar Irrigation', CAST(N'2025-05-20T00:00:00.0000000' AS DateTime2), N'/images/products/15df1f75-6546-4fc3-b3b9-d32c357f4ee7_Solar Irrigation Systems 3.png', N'4e0ce70f-201d-4d3d-a695-c2a280973aa9')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4013, N'WindMaster 500', N'High-capacity wind turbine for large farms', N'Wind Turbines', CAST(N'2024-12-31T00:00:00.0000000' AS DateTime2), N'/images/products/f7c6b9d1-ce7a-4ad9-93b7-971dafbf296b_Wind Turbines 3.png', N'4e0ce70f-201d-4d3d-a695-c2a280973aa9')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4014, N'GreenGas Converter', N'Biogas system converting manure to energy', N'Biogas Solutions', CAST(N'2025-03-10T00:00:00.0000000' AS DateTime2), N'/images/products/ce3e5f93-383b-4af0-aca0-fe941714a55e_Biogas Solutions 3.png', N'4e0ce70f-201d-4d3d-a695-c2a280973aa9')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4015, N'SolarEdge Panel 600W', N'High-efficiency solar panel with 600W output', N'Solar Panels', CAST(N'2025-02-13T00:00:00.0000000' AS DateTime2), N'/images/products/e28a1d45-1ddb-4b1d-aa94-dea4e2996e3f_Solar Panels 2.png', N'4e0ce70f-201d-4d3d-a695-c2a280973aa9')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4016, N'EnergySafe Battery System', N'Robust energy storage with 15kWh capacity', N'Energy Storage', CAST(N'2025-05-19T00:00:00.0000000' AS DateTime2), N'/images/products/2e54d589-0136-40e8-b761-70f58b02b48b_Energy Storage Systems 3.png', N'4e0ce70f-201d-4d3d-a695-c2a280973aa9')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4017, N'SunFlow Irrigation Kit', N'Affordable solar irrigation for smallholders', N'Solar Irrigation', CAST(N'2025-05-12T00:00:00.0000000' AS DateTime2), N'/images/products/573c1763-aeb4-4ecb-bcd4-1367112c989a_Solar Irrigation Systems 1.png', N'a98dd9e9-d165-44a0-815c-884426ab092c')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4018, N'BreezeWind Turbine', N'Medium-sized wind turbine with high durability', N'Wind Turbines', CAST(N'2025-05-18T00:00:00.0000000' AS DateTime2), N'/images/products/bd1f95bb-2926-463c-adc8-a038021d2b7c_Wind Turbines 2.png', N'a98dd9e9-d165-44a0-815c-884426ab092c')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4019, N'EcoBio Digester', N'Compact biogas solution for rural areas', N'Biogas Solutions', CAST(N'2025-05-21T00:00:00.0000000' AS DateTime2), N'/images/products/67260f6f-e344-4c76-879c-59a7cdbf705c_Biogas Solutions 2.png', N'a98dd9e9-d165-44a0-815c-884426ab092c')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4020, N'SolarBright Panel 450W', N'Durable solar panel suitable for harsh climates', N'Solar Panels', CAST(N'2025-01-22T00:00:00.0000000' AS DateTime2), N'/images/products/47726b59-b5f5-4d7c-9df8-08b278d32cc4_Solar Panels 3.png', N'a98dd9e9-d165-44a0-815c-884426ab092c')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4021, N'VoltStore Energy Pack', N'Energy storage with integrated inverter', N'Energy Storage', CAST(N'2025-04-15T00:00:00.0000000' AS DateTime2), N'/images/products/363b3973-6d60-4007-bdac-10c174608412_Energy Storage Systems 2.png', N'a98dd9e9-d165-44a0-815c-884426ab092c')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4022, N'AgriSolar Irrigation System', N'Smart solar irrigation with moisture sensors.', N'Solar Irrigation', CAST(N'2025-03-06T00:00:00.0000000' AS DateTime2), N'/images/products/98c71106-cb6f-4da7-9b9e-186c34283d1e_Solar Irrigation Systems 2.png', N'469421e4-cbb9-4666-a750-e6cc65aff303')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4023, N'WindEco Turbine', N'Eco-friendly wind turbine with low noise', N'Wind Turbines', CAST(N'2025-02-07T00:00:00.0000000' AS DateTime2), N'/images/products/1d067024-5c77-4575-a2e1-af7f7fdf465a_Wind Turbines 3.png', N'469421e4-cbb9-4666-a750-e6cc65aff303')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4024, N'BioCycle Energy Unit', N'Biogas system with waste recycling feature', N'Biogas Solutions', CAST(N'2025-04-23T00:00:00.0000000' AS DateTime2), N'/images/products/53d8c0ad-8590-4f29-92f8-c5aff1521b63_Biogas Solutions 3.png', N'469421e4-cbb9-4666-a750-e6cc65aff303')
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Category], [ProductionDate], [ImageUrlPath], [UserId]) VALUES (4025, N'SunPower Panel 550W', N'High-output solar panel with 25-year warranty', N'Solar Panels', CAST(N'2025-03-06T00:00:00.0000000' AS DateTime2), N'/images/products/95b360fb-141c-404c-8f6c-03362b09dcff_Solar Panels 3.png', N'469421e4-cbb9-4666-a750-e6cc65aff303')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 2025/05/12 17:38:15 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 2025/05/12 17:38:15 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 2025/05/12 17:38:15 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 2025/05/12 17:38:15 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 2025/05/12 17:38:15 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 2025/05/12 17:38:15 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 2025/05/12 17:38:15 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Products_UserId]    Script Date: 2025/05/12 17:38:15 ******/
CREATE NONCLUSTERED INDEX [IX_Products_UserId] ON [dbo].[Products]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [ArgiConnectEnergyBD] SET  READ_WRITE 
GO
