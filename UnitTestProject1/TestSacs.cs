using Microsoft.VisualStudio.TestTools.UnitTesting;
using personnageBraux.Exceptions;
using personnageBraux.Autres;

namespace personnageBraux.Test
{
    [TestClass]
    public class TestSacs
    {
        Sac sac = new Sac();
        Arme armeParDefaut = new Arme();
        [TestMethod]
        public void TestCreationSac()
        {
            try
            {
                if (sac is null)
                {
                    throw new sacCreationException();
                };
            }
            catch (sacCreationException) { }
        }
        [TestMethod]
        public void TestPushSac()
        {
            int error_number;
            try
            {
                sac.ajouterObjet(armeParDefaut); //Test de la fonction ajouter de base en ajoutant un seul objet
                if(sac.getNombreObjetDansSac() != 1)
                {
                    error_number = 1; 
                    throw new sacPushException(error_number);
                };
                for(int i=0; i< sac.getNombreObjetMaxSac(); i++)
                {
                    sac.ajouterObjet(armeParDefaut);
                }
                if (sac.getNombreObjetDansSac() != sac.getNombreObjetMaxSac()) //Test d'ajout d'un nombre d'objet supérieur au max prévu
                {
                    error_number = 2;
                    throw new sacPushException(error_number);
                };
            }
            catch (sacPushException) { }
        }
        [TestMethod]
        public void TestPopSac()
        {
            try
            {
                sac.ajouterObjet(armeParDefaut);
                sac.enleverObjet();
                if (sac.getNombreObjetDansSac() != 0)
                {
                    throw new sacPopException();
                };
            }
            catch (sacPopException) { }
        }
        [TestMethod]
        public void TestComptageSac()
        {
            try
            {
                sac.ajouterObjet(armeParDefaut);
                if (sac.getNombreObjetDansSac() != 1)
                {
                    throw new sacComptageException();
                };
            }
            catch (sacComptageException) { }
        }
    }
}
