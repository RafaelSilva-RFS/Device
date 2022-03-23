describe('My devices', () => {

    var identityBaseUrl = "https://localhost:44336//api/v1/identity/"
    var devicesApiBaseUrl = "https://localhost:44363/api/v1/"

    beforeEach(() => {
        Cypress.Cookies.debug(true)

        cy.clearCookies();

        cy.intercept(identityBaseUrl + '*').as('authLogin')

        cy.visit('http://localhost:4200/account/login')
            .get('input').clear();

        cy.get('#email').click().type('admin@device.com');
        cy.get('#password').click().type('1q2w3E*');
        cy.get('#Login').click();

        cy.wait(['@authLogin']);
    })


    it('Should show all devices', function() {
        cy.visit('http://localhost:4200/devices');
        cy.get('.device-detail-row').should('be.visible');
    });

});