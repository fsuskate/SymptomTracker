import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { SgMedsComponent } from './component/sg-meds.component';
import { SgSymptomsComponent } from './component/sg-symptoms.component';
import { StUsersComponent } from './component/st-users.component';
import { StActivitiesComponent } from './component/st-activities.component';

// Services
import { SgSymptomsService } from './service/sg-symptoms.service';
import { StUsersService } from './service/st-users.service';
import { StActivitiesService } from './service/st-activities.service';


@NgModule({
  declarations: [
    AppComponent,
    SgMedsComponent,
    SgSymptomsComponent,
    StUsersComponent,
    StActivitiesComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    HttpClientModule
  ],
  providers: [SgSymptomsService, 
    StUsersService, 
    StActivitiesService], 
  bootstrap: [AppComponent]
})
export class AppModule { }
