# Projet Pokémon TCG

Bienvenue dans notre Projet Pokemon TCG en C# :



# Objectif :

Le but de ce projet est de créer un mini-jeu de collection de cartes, tout comme le vrai jeu Pokemon TCG mais avec les 102 cartes de la première génération.

Dans le jeu vous aurez le choix entre choisir différents types de boosters pour tirer des cartes ( autant que vous voulez, car ceci n'est pas un vrai jeu avec un apsect économique dérrière).

Vous pourrez voir votre collection de cartes.

Un mode PVP est prévu, mais il n'est pas encore disponible (selon si notre jeu marche bien).

Et enfin, il y a une possibilité de réinitialisé votre collection de carte.




# Tout d'abord les outils utilisés sont :

- Visual Studio 2022 ( Pour le code)

- WampServer avec du MySql (Pour la base de données)

## Installation de la base de données

1. Allez dans PhpMyAdmin
1. Créez une base de données MySQL vide, du nom `pokemon_tcg`.
2. Allez dans l'onglet SQL de votre Base de données pokemon_tcg et copiez-collez le contenu du fichier pokemon_tcg.sql trouvable dans le dossier DataBase.



# Important

! Chose important pour que le jeu fonctionne bien et que vous puissiez tirer vos cartes et les collectionner, il faut que les identifiants de PhpMyAdmin soit les suivants :	
	- Utilisateur : root ;
	- Password :         ; ( En gros rien)
	- Choix du Serveur : MySql ; 

Car dans le code le ligne pour se connecter à la base de données est la suivante : "server=localhost;database=pokemon_tcg;user=root;password=";
Sinon,libre à vous de changer cette ligne dans CardManager.cs ligne 10.	




Ce projet a été réalisé par Adrien Borée et Tom Ballauris, étudiants à Sophia Ynov Campus.




