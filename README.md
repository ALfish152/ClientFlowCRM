# Client Flow CRM
A desktop CRM application for freelancers to manage client contacts and track sales deals through a visual pipeline.
## **Features**
- Add/edit/delete clients with name and contact details
- Add deals linked to clients with status (Lead, Contacted, Quoted, Won, Lost)
- View all clients and deals in searchable DataGridView
- Simple dashboard showing active deals count
## **Algorithmic**
- Lead Scoring: Weighted formula using Engagement (30%), Recency (40%), Deal Value (20%), Source (10%)
- Client Temperature: Auto-classifies clients as Hot (≥7.5), Warm (5.0-7.4), or Cold (<5.0) with color coding
- Follow-Up Queue: Auto-sorts clients by urgency: Temperature
   → Days Since Contact
   → Deal Value
- Inactivity Alert: Flags clients with no contact >14 days as "At Risk"
- Revenue Forecast: Weighted sum of (Deal Value × Stage Win Probability)
## **Dashboard Display**
- Summary stats (Total Clients, Active Deals, Forecasted Revenue, Pending Follow-Ups)
- Top 5 priority follow-up list
- At-risk client alert count
### Group Members
- Almira, Aeron A
- Mendoza, Ken Frankie G.
- Oliver, Jmar C.


