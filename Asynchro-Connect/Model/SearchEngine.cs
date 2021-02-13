using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchro_Connect.Model
{
    //this class is used for the searching of Active Groups and the New Groups
    static class SearchEngine
    {
        public static List<StudyGroup> SearchByStudyGroupName(List<StudyGroup> listOfGroups, String query)
        {
            List<StudyGroup> results = new List<StudyGroup>();
            String[] parsedQuery = query.Split(' ');

            foreach(StudyGroup sg in listOfGroups)
            {
                bool pass = true;
                foreach(String s in parsedQuery)
                {
                    //each word should be inside the study group name
                    if (!sg.StudyGroupName.Contains(s))
                    {
                        pass = false;
                    }
                }
                if (pass && !results.Contains(sg))
                {
                    results.Add(sg);
                }
            }
            return results;
        }
    }
}
