import { render, screen, fireEvent } from '@testing-library/react';
import Signup from '../Components/Signup'; // Adjust the import path as necessary
import axios from 'axios';
import { BrowserRouter } from 'react-router-dom';
jest.mock('axios', () => ({
  post: jest.fn()
}));

describe('Signup Component', () => {
  beforeEach(() => {
    // Clear all instances and calls to constructor and all methods:
    axios.post.mockClear();
  });

  test('allows the user to enter their name', () => {
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('name-input'), { target: { value: 'Sanjai' } });
    expect(screen.getByTestId('name-input').value).toBe('Sanjai');
  });

  test('allows the user to enter their email', () => {
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('email-input'), { target: { value: 'sanjai@gmail.com' } });
    expect(screen.getByTestId('email-input').value).toBe('sanjai@gmail.com');
  });
  
  test('allows the user to enter their password', () => {
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('password-input'), { target: { value: 'sanjai@123' } });
    expect(screen.getByTestId('password-input').value).toBe('sanjai@123');
  });

  test('allows the user to enter their mobile number', () => {
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('mobile-input'), { target: { value: '1234567890' } });
    expect(screen.getByTestId('mobile-input').value).toBe('1234567890');
  });


  test('allows the user to enter their shop name', () => {
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('shopname-input'), { target: { value: 'Sanju Store' } });
    expect(screen.getByTestId('shopname-input').value).toBe('Sanju Store');
  });

  test('allows the user to enter their location', () => {
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('location-input'), { target: { value: 'Madurai' } });
    expect(screen.getByTestId('location-input').value).toBe('Madurai');
  });

  test('allows the user to enter their GST number', () => {
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('gst-input'), { target: { value: '22AAAAA0000A1Z5' } });
    expect(screen.getByTestId('gst-input').value).toBe('22AAAAA0000A1Z5');
  }); 
  test('submits the form when all fields are valid', async () => {
    axios.post.mockResolvedValueOnce({ data: 'registersuccessfull' });
    render(<BrowserRouter><Signup /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('name-input'), { target: { value: 'John Doe' } });
    fireEvent.change(screen.getByTestId('email-input'), { target: { value: 'john@example.com' } });
    fireEvent.change(screen.getByTestId('mobile-input'), { target: { value: '1234567890' } });
    fireEvent.change(screen.getByTestId('password-input'), { target: { value: 'password123' } });
    fireEvent.change(screen.getByTestId('shopname-input'), { target: { value: 'John\'s Store' } });
    fireEvent.change(screen.getByTestId('location-input'), { target: { value: 'New York' } });
    fireEvent.change(screen.getByTestId('gst-input'), { target: { value: '22AAAAA0000A1Z5' } });
    fireEvent.submit(screen.getByTestId('submit-button'));
  });

});
