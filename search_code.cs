//I'll probably put all of this into one long function to be called on Search button push


//Compile vector of courses based on course name or course code
vector<Class> search_Code_Name(string input){
	vector<Class> search_list;
	for(Class temp : classes) //for every Class object in the array of classes
	{
		if(temp.longName == input)
		{
			search_list.push_back(temp);
		}
		else if(temp.shortName == input)
		{
			search_list.push_back(temp);
		}
		else if(temp.courseCode == input)
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
	
	return filtered;
}





