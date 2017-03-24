namespace ConciergeApp.Controllers {

    export class MainController {
        constructor(public $uibModal: ng.ui.bootstrap.IModalService, public OpenModalService: ConciergeApp.Services.OpenModalService) {
        }

        public openModal(html) {
            this.OpenModalService.openModal(html);
        }
    }

    export class ModalController {
        public feedback;

        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService,
            public feedbackId, public commentId, public $uibModalInstance: ng.ui.bootstrap.IModalServiceInstance) {
            if (feedbackId) {
                $http.get(`api/feedback/${feedbackId}`).then((res) => {
                    this.feedback = res.data;
                })
            }
        }

        public addFeedback(feedback) {
            console.log(feedback);
            this.$http.post(`api/feedback/${this.feedbackId}`, feedback).then((res) => {
                this.$state.reload();
            });
        }
        public addComment(comment) {
            console.log(comment);
            this.$http.post(`api/comment/${this.feedbackId}`,
                comment).then((res) => {
                    this.$state.reload();
                });
        }
        public closeModal() {
            this.$uibModalInstance.close();
        }

        public editFeedback() {
            this.$http.post('api/feedback', this.feedback).then((res) => {
                this.$state.reload();
                this.$uibModalInstance.close();

            })
        }
        public deleteFeedback() {
            this.$http.delete(`api/feedback/${this.feedback.id}`).then((res) => {
                this.$state.reload();
                this.$uibModalInstance.close();
            })
        }
    }

    export class AnotherController {
        public feedback;

        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService, public $uibModal: ng.ui.bootstrap.IModalService, public OpenModalService: ConciergeApp.Services.OpenModalService) {
            $http.get('api/feedback').then((res) => {
                this.feedback = res.data;

            });
        }
        public openModal(html, feedbackId, commentId, Id) {
            this.OpenModalService.openModal(html, feedbackId, commentId);
        }
    }


    export class FeedbackController {

        public feedbacks;
        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService) {
            this.$http.get('api/feedback').then((res) => {
                this.feedbacks = res.data;
            });
        }

    }
    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }

    }
    export class AboutController {
        public businesses;
        constructor(public $http: ng.IHttpService) {
            $http.get('/api/businesses').then((res) => {
                this.businesses = res.data;
                console.log(this.businesses);
            })
        }
    }
}