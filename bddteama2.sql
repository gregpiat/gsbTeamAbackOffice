USE [TeamA2]
GO
/****** Object:  Table [dbo].[commande]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commande](
	[idCommande] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[idClient] [int] NOT NULL,
	[idEtat] [int] NOT NULL,
 CONSTRAINT [PK_commande] PRIMARY KEY CLUSTERED 
(
	[idCommande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[etat]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[etat](
	[idEtat] [int] NOT NULL,
	[libelleEtat] [nchar](25) NOT NULL,
 CONSTRAINT [PK_etat] PRIMARY KEY CLUSTERED 
(
	[idEtat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[famille]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[famille](
	[idFamille] [int] NOT NULL,
	[nom] [nchar](50) NOT NULL,
 CONSTRAINT [PK_famille] PRIMARY KEY CLUSTERED 
(
	[idFamille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incompatible]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incompatible](
	[idMedicament1] [int] NOT NULL,
	[idMedicament2] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ligne]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ligne](
	[idCommande] [int] NOT NULL,
	[idMedicament] [int] NOT NULL,
	[quantite] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[medicament]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicament](
	[idMedicament] [int] NOT NULL,
	[idFamille] [int] NOT NULL,
	[nom] [nchar](25) NOT NULL,
	[effets] [nvarchar](255) NOT NULL,
	[contreIndication] [nchar](255) NOT NULL,
	[description] [nchar](255) NOT NULL,
	[dosage] [nchar](50) NOT NULL,
	[prixHorsTaxe] [float] NOT NULL,
	[prixEchantillon] [float] NOT NULL,
 CONSTRAINT [PK_medicament] PRIMARY KEY CLUSTERED 
(
	[idMedicament] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personneClient]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personneClient](
	[idClient] [int] NOT NULL,
	[nom] [nchar](25) NOT NULL,
	[prenom] [nchar](25) NOT NULL,
	[raisonSocial] [nchar](12) NOT NULL,
	[ville] [nchar](25) NOT NULL,
	[adresse] [nvarchar](50) NOT NULL,
	[cp] [nchar](5) NOT NULL,
	[email] [nchar](25) NOT NULL,
	[idTypeProfessionel] [int] NOT NULL,
 CONSTRAINT [PK_personneClient] PRIMARY KEY CLUSTERED 
(
	[idClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[typeProfessionel]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[typeProfessionel](
	[idTypeProf] [int] NOT NULL,
	[nom] [nvarchar](30) NULL,
 CONSTRAINT [PK_typeProfessionel] PRIMARY KEY CLUSTERED 
(
	[idTypeProf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[visite]    Script Date: 11/12/2014 15:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visite](
	[idVisite] [int] NOT NULL,
	[idPersonne] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[createur] [nchar](50) NOT NULL,
 CONSTRAINT [PK_visite] PRIMARY KEY CLUSTERED 
(
	[idVisite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[commande]  WITH CHECK ADD  CONSTRAINT [FK_commande_personneClient] FOREIGN KEY([idEtat])
REFERENCES [dbo].[etat] ([idEtat])
GO
ALTER TABLE [dbo].[commande] CHECK CONSTRAINT [FK_commande_personneClient]
GO
ALTER TABLE [dbo].[commande]  WITH CHECK ADD  CONSTRAINT [FK_commande_personneClient1] FOREIGN KEY([idClient])
REFERENCES [dbo].[personneClient] ([idClient])
GO
ALTER TABLE [dbo].[commande] CHECK CONSTRAINT [FK_commande_personneClient1]
GO
ALTER TABLE [dbo].[incompatible]  WITH CHECK ADD  CONSTRAINT [FK_incompatible_medicament] FOREIGN KEY([idMedicament1])
REFERENCES [dbo].[medicament] ([idMedicament])
GO
ALTER TABLE [dbo].[incompatible] CHECK CONSTRAINT [FK_incompatible_medicament]
GO
ALTER TABLE [dbo].[incompatible]  WITH CHECK ADD  CONSTRAINT [FK_incompatible_medicament1] FOREIGN KEY([idMedicament2])
REFERENCES [dbo].[medicament] ([idMedicament])
GO
ALTER TABLE [dbo].[incompatible] CHECK CONSTRAINT [FK_incompatible_medicament1]
GO
ALTER TABLE [dbo].[ligne]  WITH CHECK ADD  CONSTRAINT [FK_ligne_commande] FOREIGN KEY([idCommande])
REFERENCES [dbo].[commande] ([idCommande])
GO
ALTER TABLE [dbo].[ligne] CHECK CONSTRAINT [FK_ligne_commande]
GO
ALTER TABLE [dbo].[ligne]  WITH CHECK ADD  CONSTRAINT [FK_ligne_medicament] FOREIGN KEY([idMedicament])
REFERENCES [dbo].[medicament] ([idMedicament])
GO
ALTER TABLE [dbo].[ligne] CHECK CONSTRAINT [FK_ligne_medicament]
GO
ALTER TABLE [dbo].[medicament]  WITH CHECK ADD  CONSTRAINT [FK_medicament_famille] FOREIGN KEY([idFamille])
REFERENCES [dbo].[famille] ([idFamille])
GO
ALTER TABLE [dbo].[medicament] CHECK CONSTRAINT [FK_medicament_famille]
GO
ALTER TABLE [dbo].[personneClient]  WITH CHECK ADD  CONSTRAINT [FK_personneClient_personneClient] FOREIGN KEY([idTypeProfessionel])
REFERENCES [dbo].[typeProfessionel] ([idTypeProf])
GO
ALTER TABLE [dbo].[personneClient] CHECK CONSTRAINT [FK_personneClient_personneClient]
GO
ALTER TABLE [dbo].[visite]  WITH CHECK ADD  CONSTRAINT [FK_visite_personneClient] FOREIGN KEY([idPersonne])
REFERENCES [dbo].[personneClient] ([idClient])
GO
ALTER TABLE [dbo].[visite] CHECK CONSTRAINT [FK_visite_personneClient]
GO
