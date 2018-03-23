//I'll probably put all of this into one long function to be called on Search button push


//Compile vector of courses based on course name or course code

/*
Changed to accept substrings of long&short name, code, and partial matching meeting days
*/
vector<Class> search_Code_Name(string input){
	vector<Class> search_list;
	input = input.toUpper;
	for(Class temp : classes) //for every Class object in the array of classes
	{
		if((temp.longName).Contains(input))
		{
			search_list.push_back(temp);
		}
		else if((temp.shortName).Contains(input))
		{
			search_list.push_back(temp);
		}
		else if((temp.courseCode).Contains(input))
		{
			search_list.push_back(temp);
		}
	}
	return search_list;
}

//filter created vector based on time range
vector<Class> filter_TimeRange(string input){
	vector<Class> filtered;
	for(Class temp: search_list){
		if(temp.beginTime == input) //I need to know how the UI structures the input values before this is final
		{
			filtered.push_back(temp);
		}
	}
	return filtered;
}

//filter created vector based on meeting days
vector<Class> filter_MeetDays(string *days) //could input multiple days
//for the UI, may just check value of certain checkboxes
{
	vector<Class> filtered;
	
	//I'm still not sure of this algorithm
	
	string temp = "";
	//concatenate all days 
	if(checkMon.checked = true)
	{
		temp += "M";
	}
	if(checkTue.checked = true)
	{
		temp += "T";
	}
	if(checkWed.checked = true)
	{
		temp += "W";
	}
	if(checkThu.checked = true)
	{
		temp += "R";
	}
	if(checkFri.checked = true)
	{
		temp += "F";
	}
	
	//push_front any classes with meet strings that match exactly	
	//push_back classes with meet containing temp
	for(Class classTemp : classes)
	{
		if(classTemp.meets == temp)
		{
			filtered.push_front(classTemp);
		}
		else if((classTemp.meets).Contains(temp))
		{
			filtered.push_back(classTemp); //this will hopefully make classes that exactly meet on user-specified days appear at the top of the list
		}
	}
	return filtered;
}
