using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    public class Filter
    {
        //takes pre-filtered list of classes and filtering spec. days
        //returns filtered list
        public List<Course> Filter_Days(List<Course> search_List, List<String> days)
        {
            Course[] tempList = new Course[search_List.Count];
            search_List.CopyTo(tempList);
            foreach (Course tempC in tempList)
            {
                foreach (string tempSS in days)
                {
                    if (!(tempC.meets.Contains(tempSS)))
                    {
                        search_List.Remove(tempC);
                        break;
                    }
                }
            }
            return search_List;
        }

        //takes pre-filtered list of classes and filtering spec. time
        //returns filtered list
        public List<Course> Filter_Time(List<Course> search_List, int bR_hours, int eR_hours, int bR_min, int eR_min)
        {
            int temp_B_H = 0, temp_B_M = 0, temp_E_H = 0, temp_E_M = 0;
            Course[] tempList = new Course[search_List.Count];
            search_List.CopyTo(tempList);
      
            if (bR_hours != 0 && eR_hours != 0) //filter by full time range
            {
                foreach(Course tempC in tempList)
                {
                    if (tempC.beginTime != "NULL" && tempC.endTime!= "NULL")
                    {
                        string[] tempStr = tempC.beginTime.Split(':');
                        int.TryParse(tempStr[0], out temp_B_H);
                        int.TryParse(tempStr[1], out temp_B_M);

                        tempStr = tempC.endTime.Split(':');
                        int.TryParse(tempStr[0], out temp_E_H);
                        int.TryParse(tempStr[1], out temp_E_M);

                        //check for greater/equal begin
                        if (bR_hours > temp_B_H || (bR_hours == temp_B_H && bR_min > temp_B_M))
                        {
                            search_List.Remove(tempC);
                        }

                        //check for less/equal end
                        else if (eR_hours < temp_E_H || (eR_hours == temp_E_H && eR_hours < temp_E_M))
                        {
                            search_List.Remove(tempC);
                        }
                    }
                    else
                    {
                        search_List.Remove(tempC);
                    }
                }
            }
            else if(bR_hours!= 0) //filter by beginning time range
            {
                foreach (Course tempC in tempList)
                {
                    if (tempC.beginTime != "NULL" && tempC.endTime != "NULL")
                    {
                        string[] tempStr = tempC.beginTime.Split(':');
                        int.TryParse(tempStr[0], out temp_B_H);
                        int.TryParse(tempStr[1], out temp_B_M);

                        //check for greater/equals begin
                        if (bR_hours > temp_B_H || (bR_hours == temp_B_H && bR_min > temp_B_M))
                        {
                            search_List.Remove(tempC);
                        }
                    }
                    else
                    {
                        search_List.Remove(tempC);
                    }
                }

            }
            else if(eR_hours != 0) //filter by ending time range
            {
                foreach (Course tempC in tempList)
                {
                    if (tempC.beginTime != "NULL" && tempC.endTime != "NULL")
                    {
                        string[] tempStr = tempC.endTime.Split(':');
                        int.TryParse(tempStr[0], out temp_E_H);
                        int.TryParse(tempStr[1], out temp_E_M);

                        //check for less/equal to end
                        if (eR_hours < temp_E_H || (eR_hours == temp_E_H && eR_hours < temp_E_M))
                        {
                            search_List.Remove(tempC);
                        }
                    }
                    else
                    {
                        search_List.Remove(tempC);
                    }
                }
               
            } 

            return search_List;
        }

        //takes pre-filtered list of classes
        //returns filtered list
        public List<Course> Filter_Popular(List<Course> search_List)
        {
            Course[] tempList = new Course[search_List.Count];
            search_List.CopyTo(tempList);
            foreach (Course tempC in tempList)
            {
                //TO FIND THE "difficulty" LEVEL OF THE COURSE
                //Take the course name
                string[] tempName = tempC.courseCode.Split(' ');
                //chop off the letters
                //int level = class number - (class number %100)/100
                int level = 0;
                int.TryParse((tempName[1])[0].ToString(), out level);  //if this fails level will remain 0
 
                //if popularity score is under a certain point, course code begins with HUMA or WRIT or SSFT
                if(tempName[0] == "HUMA" | tempName[0] == "WRIT" | tempName[0] == "SSFT" | (tempC.creditHours+level)/2 > 3)
                {
                    //remove it from search_List
                    search_List.Remove(tempC);
                }  
            }
            return search_List;
        }
    }
}
