namespace ConciergeApp.Controllers {

    export class ProfileController {
        public applicationUser;
        public appUserId;
        public feedbacks;
        public feedback;
        public comments;

        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService, public $stateParams: ng.ui.IStateParamsService, public OpenModalService: ConciergeApp.Services.OpenModalService) {
            $http.get('/api/applicationUser/getLoginUser').then((res) => {
                this.applicationUser = res.data;
                console.log(this.applicationUser);
            })
            this.$http.get('api/feedback').then((res) => {
                this.feedbacks = res.data;
                console.log(this.feedbacks);
            })
            this.$http.get('api/comments').then((res) => {
                this.comments = res.data;
            });
            
        }
        public openModal(html, feedbackId) {
            this.OpenModalService.openModal(html, feedbackId);
        }

    }
}