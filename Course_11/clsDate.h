#pragma warning(disable : 4996)
#pragma once

#include <iostream>
#include <string>

using namespace std;

namespace date 
{

	class clsDate
	{
		short _Day = 0;
		short _Month = 0;
		short _Year = 0;


		int ReadNumber(string message)
		{
			int number = 0;

			cout << message;
			cin >> number;


			return number;
		}

		string ReadString(string message)
		{
			string text = "";

			cout << message;
			cin >> text;


			return text;
		}

		clsDate ReadFullDate()
		{
			clsDate Date;

			Date._Day = ReadNumber("Plz enter a day ? ");
			Date._Month = ReadNumber("Plz enter a month ? ");
			Date._Year = ReadNumber("Plz enter a year ? ");

			cout << endl;

			return Date;
		}

	public:

		void SetDay(short day) 
		{
			_Day = day;
		}

		short GetDay() 
		{
			return _Day;
		}

		void SetMonth(short month)
		{
			_Month = month;
		}

		short GetMonth()
		{
			return _Month;
		}

		void SetYear(short year)
		{
			_Year = year;
		}

		short GetYear()
		{
			return _Year;
		}

		clsDate GetSystemTime()
		{
			clsDate Date;

			time_t now = time(nullptr);

			tm local_time;

			localtime_s(&local_time, &now);


			Date._Year = 1900 + local_time.tm_year;
			Date._Month = 1 + local_time.tm_mon;
			Date._Day = local_time.tm_mday;

			return Date;
		}

		static bool IsLeapYear(short year)
		{
			return year % 400 == 0 ? true : year % 100 != 0 && year % 4 == 0 ? true : false;
		}

		bool IsLeapYear() 
		{
			return IsLeapYear(_Year);
		}

		static int NumberOfDaysInMonth(short year, short month)
		{
			if (month < 1 || month > 12)
				return 0;

			int arr12Days[] = { 31,30,31,30,31,30,31,31,30,31,30,31 };

			return month == 2 ? (IsLeapYear(year) ? 29 : 28) : arr12Days[month - 1];
		}

		int NumberOfDaysInMonth()
		{
			NumberOfDaysInMonth(_Year, _Month);
		}

		static bool IsValidMonth(clsDate Date)
		{
			return (Date._Month <= 12) && (Date._Month >= 1);
		}

		bool IsValidMonth()
		{
			IsValidMonth(*this);
		}

		static bool IsValidDay(clsDate Date)
		{
			return  (Date._Day >= 1) && (Date._Day <= NumberOfDaysInMonth(Date._Year, Date._Month));
		}

		bool IsValidDay()
		{
			return IsValidDay(*this);
		}

		static bool IsValidDate(clsDate Date)
		{
			return IsValidMonth(Date) && IsValidDay(Date);
		}

		bool IsValidDate()
		{
			IsValidDay(*this);
		}

		clsDate StringToDate(string strDate)
		{
			clsDate Date;

			short count = 0;

			for (short i = 0; i < strDate.length(); i++)
			{
				if (strDate[i] == '/')
				{

					count == 0 ? Date._Day = stoi(strDate.substr(0, i)) : Date._Month = stoi(strDate.substr(0, i));
					strDate.erase(0, i + 1);

					count++;
					i = 0;
				}
			}

			Date._Year = stoi(strDate);

			return Date;
		}

		static clsDate GetDateFromDayOrderInYear(short dayOrderInYear, short year)
		{
			clsDate Date;

			short month = 1;
			short remmaningDays = 0;

			while (true)
			{
				if (remmaningDays < dayOrderInYear)
				{
					remmaningDays += NumberOfDaysInMonth(year, month);
					month++;
				}
				else
				{
					Date._Year = year;
					Date._Month = month - 1;
					Date._Day = NumberOfDaysInMonth(year, month - 1) - (remmaningDays - dayOrderInYear);

					break;
				}

			}

			return Date;
		}

		clsDate GetDateFromDayOrderInYear(short dayOrderInYear)
		{
			GetDateFromDayOrderInYear(dayOrderInYear,  _Year);
		}

		static int NumberOfDaysFromBeginningOfYear(short year, short month, short day)
		{
			int sum = 0;

			for (int i = 1; i < month; i++)
			{
				sum += NumberOfDaysInMonth(year, i);
			}

			return sum + day;
		}

		void NumberOfDaysFromBeginningOfYear()
		{
			NumberOfDaysFromBeginningOfYear(_Year, _Month, _Day);
		}

		static bool IsDate1EqualDate2(clsDate Date1, clsDate Date2)
		{

			return (Date1._Year == Date2._Year) ? ((Date1._Month == Date2._Month) ? (Date1._Day == Date2._Day) : false ? true : false) : false;
		}

		bool IsDateEqualDate2(clsDate Date2)
		{
			return IsDate1EqualDate2(*this, Date2);
		}


		static bool IsDate1BeforeDate2(clsDate Date1, clsDate Date2)
		{
			return Date1._Year < Date2._Year ? true : Date1._Year == Date2._Year ? Date1._Month < Date2._Month ? true : Date1._Month == Date2._Month ? Date1._Day < Date2._Day ? true : false : false : false;
		}

		bool IsDateBeforeDate2(clsDate Date2)
		{
			return IsDate1BeforeDate2(*this, Date2);
		}

		static bool IsDate1AfterDate2(clsDate Date1, clsDate Date2)
		{
			return (!IsDate1BeforeDate2(Date1, Date2) && !IsDate1EqualDate2(Date1, Date2)) ? true : false;
		}

		bool IsDateAfterDate2(clsDate Date2)
		{
			IsDate1AfterDate2(*this, Date2);
		}

		static int DaysDiff(clsDate Date1, clsDate Date2, bool IncludeEndDay = false)//2000-2022
		{

			int sumOfDays = 0;

			if (IsDate1BeforeDate2(Date1, Date2))
			{
				for (int i = Date1._Year; i < Date2._Year; i++)
				{
					sumOfDays += NumberOfDaysFromBeginningOfYear(i, 12, 31);
				}

				sumOfDays += NumberOfDaysFromBeginningOfYear(Date2._Year, Date2._Month, Date2._Day) - NumberOfDaysFromBeginningOfYear(Date1._Year, Date1._Month, Date1._Day);
			}
			else
			{
				for (int i = Date2._Year; i < Date1._Year; i++)
				{
					sumOfDays += NumberOfDaysFromBeginningOfYear(i, 12, 31);
				}

				sumOfDays += NumberOfDaysFromBeginningOfYear(Date1._Year, Date1._Month, Date1._Day) - NumberOfDaysFromBeginningOfYear(Date2._Year, Date2._Month, Date2._Day);

				sumOfDays *= -1;
			}

			return sumOfDays;
		}

		int DaysDiff(clsDate Date2, bool IncludeEndDay = false)//2000-2022
		{

			return DaysDiff(*this, Date2, IncludeEndDay);
		}

		static bool IsDayLastDayInMonth(clsDate Date)
		{
			return Date._Day == NumberOfDaysInMonth(Date._Year, Date._Month) ? true : false;
		}

		bool IsDayLastDayInMonth()
		{
			return IsDayLastDayInMonth(*this);

		}
		
		static bool IsMonthLastMonthInYear(clsDate Date)
		{
			return Date._Month == 12 ? true : false;
		}

		bool IsMonthLastMonthInYear()
		{
			return IsMonthLastMonthInYear(*this);
		}

		static clsDate IncreaseDateByOneDay(clsDate Date)
		{
			if (IsDayLastDayInMonth(Date))
			{
				if (IsMonthLastMonthInYear(Date))
				{
					Date._Day = 1;
					Date._Month = 1;
					Date._Year++;
				}
				else
				{
					Date._Day = 1;
					Date._Month++;

				}
			}
			else
			{
				Date._Day++;
			}


			return Date;
		}

		void IncreaseDateByOneDay()
		{
			*this = IncreaseDateByOneDay(*this);
		}

		static clsDate IncreaseDateByXDays(clsDate Date, int howManyDays)
		{
			for (short i = 1; i <= howManyDays; i++)
			{
				Date = IncreaseDateByOneDay(Date);

			}

			return Date;
		}

		void IncreaseDateByXDays( int howManyDays)
		{
			*this = IncreaseDateByXDays(*this, howManyDays);
		}

		static clsDate IncreaseDateByOneWeek(clsDate Date)
		{

			Date = IncreaseDateByXDays(Date, 7);

			return Date;
		}

		void IncreaseDateByOneWeek()
		{

			*this = IncreaseDateByOneWeek(*this);
		}

		static clsDate IncreaseDateByXWeeks(clsDate Date, int howManyWeeks)
		{
			for (int i = 1; i <= howManyWeeks; i++)
			{
				Date = IncreaseDateByXDays(Date, 7);
			}

			return Date;
		}

		void IncreaseDateByXWeeks(int howManyWeeks)
		{
			*this = IncreaseDateByXWeeks(*this, howManyWeeks);
		}



		clsDate()
		{
			clsDate Date = GetSystemTime();

			_Day = Date._Day;
			_Month = Date._Month;
			_Year = Date._Year;

		}

		clsDate(string date)
		{
			clsDate Date = StringToDate(date);

			_Day = Date._Day;
			_Month = Date._Month;
			_Year = Date._Year;

		}

		clsDate(short day, short month, short year)
		{
			_Day = day;
			_Month = month;
			_Year = year;
		}

		clsDate(short totalDays, short year)
		{
			clsDate Date = GetDateFromDayOrderInYear(totalDays, year);

			_Day = Date._Day;
			_Month = Date._Month;
			_Year = Date._Year;
		}

	};

}


