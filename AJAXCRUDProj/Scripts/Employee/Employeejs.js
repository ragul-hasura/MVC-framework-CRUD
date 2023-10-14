jQuery('#submitForm').validate({
	rules: {
		Name: "required",
		//email: {
		//	required: true,
		//	email: true
		//},
		Age: {
			required: true,
			//minlength: 5
		},
		State: {
			required: true,
			
		},
		Country: {
			required: true,
			
		},
		Salary: {
			required: true,
			
		},
		EmployeeId: {
			required: true,

		},
	}, messages: {
		Name: "Please enter your name",
		//email: {
		//	required: "Please enter email",
		//	email: "Please enter valid email",
		//},
		Age: {
			required: "Please enter your password",
			//minlength: "Password must be 5 char long"
		},
		State: {
			required: "Please enter your State",
		},
		Country: {
			required: "Please enter your Country",
		},
		Salary: {
			required: "Please enter your Salary",
		},
		EmployeeId: {
			required: "Please enter your EmployeeId",
		},
	},
	submitHandler: function (form) {
		form.submit();
	}
});