import { render, screen, fireEvent } from '@testing-library/react';
import Signin from '../Components/Signin'; // Adjust the import path as necessary
import axios from 'axios';
import { BrowserRouter } from 'react-router-dom';
jest.mock('axios', () => ({
  post: jest.fn()
}));

describe('Signin Component', () => {
  beforeEach(() => {
    // Clear all instances and calls to constructor and all methods:
    axios.post.mockClear();
  });

  test('allows the user to enter their email', () => {
    render(<BrowserRouter><Signin /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('input-Email'), { target: { value: 'sanjai@gmail.com' } });
    expect(screen.getByTestId('input-Email').value).toBe('sanjai@gmail.com');
  });

  test('allows the user to enter their password', () => {
    render(<BrowserRouter><Signin /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('input-Password'), { target: { value: 'sanjai@123' } });
    expect(screen.getByTestId('input-Password').value).toBe('sanjai@123');
  });

  test('Login the form when all fields are valid', async () => {
    axios.post.mockResolvedValueOnce({ data: 'Loginsuccessfull' });
    render(<BrowserRouter><Signin /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('input-Email'), { target: { value: 'john@example.com' } });
    fireEvent.change(screen.getByTestId('input-Password'), { target: { value: 'password123' } });
    fireEvent.submit(screen.getByTestId('Login-button'));
  });

});
