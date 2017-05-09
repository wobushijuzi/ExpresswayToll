var Login = function() {

    var handleLogin = function() {

        //$('.login-form').validate({
        //    errorElement: 'span', //default input error message container
        //    errorClass: 'help-block', // default input error message class
        //    focusInvalid: false, // do not focus the last invalid input
        //    rules: {
        //        username: {
        //            required: true
        //        },
        //        password: {
        //            required: true
        //        },
        //        remember: {
        //            required: false
        //        }
        //    },

        //    messages: {
        //        username: {
        //            required: "Username is required."
        //        },
        //        password: {
        //            required: "Password is required."
        //        }
        //    },

        //    invalidHandler: function(event, validator) { //display error alert on form submit   
        //        $('.alert-danger', $('.login-form')).show();
        //    },

        //    highlight: function(element) { // hightlight error inputs
        //        $(element)
        //            .closest('.form-group').addClass('has-error'); // set error class to the control group
        //    },

        //    success: function(label) {
        //        label.closest('.form-group').removeClass('has-error');
        //        label.remove();
        //    },

        //    errorPlacement: function(error, element) {
        //        error.insertAfter(element.closest('.input-icon'));
        //    },

        //    submitHandler: function(form) {
        //        form.submit(); // form validation success, call ajax form submit
        //    }
        //});

        $('.login-form input').keypress(function(e) {
            if (e.which == 13) {
                if ($('.login-form').validate().form()) {
                    $('.login-form').submit(); //form validation success, call ajax form submit
                }
                return false;
            }
        });
    }

    
    var handleRegister = function() {

        function format(state) {
            if (!state.id) { return state.text; }
            var $state = $(
             '<span><img src="../assets/global/img/flags/' + state.element.value.toLowerCase() + '.png" class="img-flag" /> ' + state.text + '</span>'
            );
            
            return $state;
        }

        if (jQuery().select2 && $('#country_list').size() > 0) {
            $("#country_list").select2({
	            placeholder: '<i class="fa fa-map-marker"></i>&nbsp;Select a Country',
	            templateResult: format,
                templateSelection: format,
                width: 'auto', 
	            escapeMarkup: function(m) {
	                return m;
	            }
	        });


	        $('#country_list').change(function() {
	            $('.register-form').validate().element($(this)); //revalidate the chosen dropdown value and show error or success message for the input
	        });
    	}

       
        $('.register-form input').keypress(function(e) {
            if (e.which == 13) {
                if ($('.register-form').validate().form()) {
                    $('.register-form').submit();
                }
                return false;
            }
        });

        jQuery('#register-btn').click(function() {
            jQuery('.login-form').hide();
            jQuery('.register-form').show();
        });

        jQuery('#register-back-btn').click(function() {
            jQuery('.login-form').show();
            jQuery('.register-form').hide();
        });
    }

    return {
        //main function to initiate the module
        init: function() {

            handleLogin();
            handleRegister();

        }

    };

}();

jQuery(document).ready(function() {
    Login.init();
});