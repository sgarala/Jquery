demoApp.factory('gravatarUrlBuilder', function() {
    return {
        buildGravatarUrl: function (Email) {
            var defaultGravetar = 'http://www.gravatar.com/avatar/000?s=200';
            var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
            if (!re.test(Email))
                return defaultGravetar;
            //Email = trim(Email); // "MyEmailAddress@example.com"
            //Email = converters.toLowerCase(Email); // "myemailaddress@example.com"
            var mD5 = calcMD5(Email);
            defaultGravetar = 'http://www.gravatar.com/avatar/' + mD5 + '.jpg?s=200&r=g';
            return defaultGravetar;
        }
    }
});