# Seizure Tracker

## Purpose
The purpose of this program is to track when a person has a seizure so it can be reported to their doctor. This app does not make any medical recommendations and will only track when a person has a seizure. 

## Useage
The API drogram must be running in the background this will process the tracking and handle the data reading and writing. It communicates in via a API, it is recommended to also run the UI program and open it in a web browser at https://localhost:7001 but the API can be used with any API program for example postman. The purpose of running the API
locally is to maintain your control of your own data. The creator of this proogram does not have any access to any form of data in your instance.

## Future Features
This app is still heavy in development and lacks many features, in order of priority.
- [ ] The ability to actually record seizures, currently can only read and create caregivers and patients.
- [ ] The ability to see patient data from the caregivers menu.
- [ ] The ability to export the JSON data into other file formats for example csv or xlsx.
- [ ] THe ability to store data in a SQLite database rather instead of just JSON.
- [ ] The ability to generate a formatted report likely in a PDF format.

