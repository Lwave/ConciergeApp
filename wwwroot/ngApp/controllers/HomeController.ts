namespace ConciergeApp.Controllers {

    export class HomeController {
        public places;
        public result1;
        public options1;
        public details1;
        public result2;
        public options2;
        public details2;

        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService) {

            this.result1 = '';
            this.options1 = null;
            this.details1 = '';
            this.result2 = '';
            this.options2 = 'types = establishment';
            this.details2 = '';

        }


        public searchPlacesByKeyword(keyword, loc) {
            localStorage['keyword'] = keyword;
            localStorage['loc'] = loc;
            this.$state.go('searchResults');
            console.log(loc);

        }
    }
}
