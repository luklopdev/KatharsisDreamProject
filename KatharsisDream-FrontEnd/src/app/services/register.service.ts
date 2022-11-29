import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RegisterUserModel } from "../models/register-user.model";

@Injectable()
export class RegisterService{
    constructor(private httpClient: HttpClient){

    }

    registerAccount(accountData: RegisterUserModel){
        return this.httpClient.post<RegisterUserModel>('', {});
    }
}