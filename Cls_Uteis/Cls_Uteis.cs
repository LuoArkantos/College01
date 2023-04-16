using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_Uteis
{
    public class Cls_Uteis
    {

        public static bool ValidaProfessor(string password)
        {

            List<string> senhasProf = new List<string>()
        {
            "prof0",
            "prof1",
            "prof2",
            "prof3",
            "prof4",
            "prof5",
            "prof6",
            "prof7",
            "prof8",
            "prof9"

        };

            for (int i = 0; i < senhasProf.Count; i++)
            {
                if (password == senhasProf[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ValidaCoordenador(string password)
        {

            List<string> senhasCoord = new List<string>()
        {
            "coord0",
            "coord1",
            "coord2",
            "coord3",
            "coord4",
            "coord5",
            "coord6",
            "coord7",
            "coord8",
            "coord9"

        };

            for (int i = 0; i < senhasCoord.Count; i++)
            {
                if (password == senhasCoord[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}