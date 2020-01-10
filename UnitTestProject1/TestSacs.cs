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
            try
            {
                sac.ajouterObjet(armeParDefaut);
                if(sac.getNombreObjetDansSac() != 1)
                {
                    throw new sacPushException();
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
