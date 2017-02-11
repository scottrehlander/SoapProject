<?php

	$client = new SoapClient("http://98.118.100.229/PresentationDemo/PresentationDemo/PresentationDemo/PresentationDemoService.svc?wsdl");

	// Make the queries to our webservice
	$teacherNameResult = $client->getTeacherName();
	$commentsResult = $client->getComments();

	// Header for page
	echo("<h1>View Commentds:</h1><h2>PHP Example from Remote Server</h2><br />");

	// Show the teacher name results
	echo("<h3>getTeacherName():</h3><ul>" . $teacherNameResult->GetTeacherNameResult . "</ul>");
	echo(" <br /> ");

	// Grab the comments
	echo("<h3>getComments():</h3>");
		foreach($commentsResult->GetCommentsResult->string as $comment)
			echo("<ul>" . $comment . "</ul>");

?>