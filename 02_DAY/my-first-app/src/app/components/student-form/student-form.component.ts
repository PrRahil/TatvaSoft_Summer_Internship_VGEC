import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student-form',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './student-form.component.html',
  styleUrl: './student-form.component.css',
})
export class StudentFormComponent {
  studentName: string = '';
  enrollmentNumber: string = '';
  email: string = '';
  mobileNumber: string = '';
  submitted: boolean = false;
  students: string[] = [];

  // Validation flags
  isValidEmail: boolean = true;
  isValidMobile: boolean = true;
  isValidEnrollment: boolean = true;

  validateEmail() {
    const emailPattern = /^[a-zA-Z0-9._]+@[a-zA-Z0-9.]+\.[a-zA-Z]{2,4}$/;
    this.isValidEmail = emailPattern.test(this.email);
  }

  validateMobile() {
    const mobilePattern = /^[0-9]{10}$/;
    this.isValidMobile = mobilePattern.test(this.mobileNumber);
  }

  validateEnrollment() {
    this.isValidEnrollment = this.enrollmentNumber.length >= 5;
  }

  submitForm() {
    this.validateEmail();
    this.validateMobile();
    this.validateEnrollment();

    if (
      this.studentName.length > 3 &&
      this.isValidEmail &&
      this.isValidMobile &&
      this.isValidEnrollment
    ) {
      const studentInfo = `${this.studentName} (${this.enrollmentNumber}) - ${this.email} - ${this.mobileNumber}`;
      this.students.push(studentInfo);
      this.submitted = true;

      // Reset form fields after submission
      this.resetForm();
    } else {
      this.submitted = false;
    }
  }

  resetForm() {
    this.studentName = '';
    this.enrollmentNumber = '';
    this.email = '';
    this.mobileNumber = '';
  } 
}
