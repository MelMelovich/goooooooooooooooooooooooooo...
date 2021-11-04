using System;
// Класс пользователя 
// содержит код пользователя и Имя пользователя


namespace даааааааааааааваааааааааааааааааааааай
	
public class User
{
  private int id;
  private string Name;
  
  // Конструктор Класса 
  // передаем id и Name
	public User(int id_, string Name_)
	{
	  id = id_;
    Name = Name_;
	}
	
  
  private string GetName(){
   return Name;
  }  
 
  private int GetId(){
   return id;
  }  
 
}
