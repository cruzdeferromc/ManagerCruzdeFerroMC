sqlcmd -S (local) -Q "ALTER DATABASE [36Manager_testes] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE"
sqlcmd -S (local) -Q "drop database [36Manager_testes]"
sqlcmd -S (local) -i metadata.sql
sqlcmd -S (local) -i dados.sql