function check(input) {
	if (document.getElementById('confirm_password').value != document.getElementById('password').value) {
		input.setCustomValidity("Passwords doesn't match, please try again!");
	} else {
		input.setCustomValidity('');
	}
}