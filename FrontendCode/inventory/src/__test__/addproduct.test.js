import { render, screen, fireEvent } from '@testing-library/react';
import Addproduct from '../Components/Product/Addproduct'; // Adjust the import path as necessary
import axios from 'axios';
import { BrowserRouter } from 'react-router-dom';
// Mock axios post call
jest.mock('axios', () => ({
  post: jest.fn()
}));

describe('Addproduct Component', () => {
  beforeEach(() => {
    axios.post.mockClear();
  });

  test('allows the Retailer to enter their Productcode', () => {
    render(<BrowserRouter><Addproduct /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('productcode-input'), { target: { value: '89786' } });
    expect(screen.getByTestId('productcode-input').value).toBe('89786');
  });

  test('allows the Retailer to enter their productCategory', () => {
    render(<BrowserRouter><Addproduct /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('productCategory-input'), { target: { value: 'chocolate' } });
    expect(screen.getByTestId('productCategory-input').value).toBe('chocolate');
  });

  test('allows the Retailer to enter their productName', () => {
    render(<BrowserRouter><Addproduct /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('productName-input'), { target: { value: 'Kitkat' } });
    expect(screen.getByTestId('productName-input').value).toBe('Kitkat');
  });


  test('allows the Retailer to enter their description', () => {
    render(<BrowserRouter><Addproduct /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('description-input'), { target: { value: 'Kit Kat is a chocolate-covered wafer bar confection created by Rowntree  of York, United Kingdom.' } });
    expect(screen.getByTestId('description-input').value).toBe('Kit Kat is a chocolate-covered wafer bar confection created by Rowntree  of York, United Kingdom.');
  });

  test('allows the Retailer to enter their buyingPrice', () => {
    render(<BrowserRouter><Addproduct /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('buyingPrice-input'), { target: { value: "36" } });
    expect(screen.getByTestId('buyingPrice-input').value).toBe("36");
  });

  test('allows the Retailer to enter their sellingPrice', () => {
    render(<BrowserRouter><Addproduct /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('sellingPrice-input'), { target: { value:"40" } });
    expect(screen.getByTestId('sellingPrice-input').value).toBe("40");
  }); 
  test('allows the Retailer to enter their stock', () => {
    render(<BrowserRouter><Addproduct /></BrowserRouter>);
    fireEvent.change(screen.getByTestId('stock-input'), { target: { value: "1200" } });
    expect(screen.getByTestId('stock-input').value).toBe("1200");
  }); 
});
