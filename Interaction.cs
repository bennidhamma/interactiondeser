using System;
using System.Collections.Generic;

namespace interactiondeser
{	
	public class InteractionWrapper
	{
		public Interaction interaction {get; set;}
	}
	
	public class Interaction
	{
		public string id {get; set;}
		public string content {get; set;}
		public DateTime createdAt {get; set;}
		public string source {get; set;}
		public 	string kind {get; set;}
		
		public class Author {
			public int id {get; set;}
			public string username {get; set;}
			public string name {get; set;}
			public string avatar {get; set;}
		}
		
		public Author author {get; set;}
		
		public class Twitter {
			public long id {get; set;}
			public List<string> mentions {get; set;}
			
			public class User {
				public int id {get; set;}
				public string description {get; set;}
				public string url {get; set;}
				public string lang {get; set;}
				public string timeZone {get; set;}
				public int statusesCount {get; set;}
				public int followersCount {get; set;}
				public int friendsCount {get; set;}
			}
			
			public User user {get; set;}
		}
		
		public Twitter twitter {get; set;}
		
		public class Salience {
			public int sentiment {get; set;}
		}
		
		public Salience salience {get; set;}
		
		public class Klout {
			public int score {get; set;}			
			public int network {get; set;}			
			public int amplification {get; set;}			
			public int trueReach {get; set;}
			public int slope {get; set;}
			public string clazz {get; set;}
		}
		
		public Klout klout {get; set;}			
	}
}