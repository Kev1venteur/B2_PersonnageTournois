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
        public void TestPushSac()
        {
            try
            {
                sac.ajouterObjet(armeParDefaut);
                if(sac.getNombreObjetDansSac() != 1)
                {
                    throw new sacPushNeFonctionnePas();
                };
            }
            catch (sacPushNeFonctionnePas){}
        }
        [TestMethod]
        public void TestPopSac()
        {
            try
            {
                sac.enleverObjet();
                if (sac.getNombreObjetDansSac() != 0)
                {
                    throw new sacPopNeFonctionnePas();
                };
            }
            catch (sacPopNeFonctionnePas){}
        }
    }
}
